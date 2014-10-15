using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class HandleStartMenuChoice
	{
		private static List<Blog> _blogs;
		private static int _choice;

		public static int GetChoice()
		{
			return _choice;
		}

		public static void HandleChoice(List<Blog> blogs)
		{
			_blogs = blogs;

			Console.WriteLine("Choose an alternative: ");
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
			{
				Console.WriteLine("Please try with an integer 0-2.");
			}

			_choice = choice;

			switch (choice)
			{
				case 1:
					Blog newBlog = NewBlog();
					_blogs.Add(newBlog);
					MainMenu.RunMenu(newBlog);
					break;

				case 2:
					MenuListOfBlogs.Show(_blogs);
					HandleChoiceOfBlog.BlogChooser(_blogs);
					Blog chosenBlog = HandleChoiceOfBlog.GetChosenBlog();
					MainMenu.RunMenu(chosenBlog);
					break;

				case 0:
					Environment.Exit(0);
					break;
			}
		}

		private static Blog CreateBlog()
		{
			Console.WriteLine("Namnge din nya blogg: ");
			Blog blog = new Blog(Console.ReadLine());
			Console.Title = blog.Name;

			return blog;
		}

		private static Blog NewBlog()
		{
			Blog blog = CreateBlog();
			CreateTestEntries testEntryCreator = new CreateTestEntries(blog);
			blog = testEntryCreator.GetBlog();
			return blog;
		}
	}
}
