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
					MenuBlogList();
					Blog blogChoice = GetBlogChoice();
					MainMenu.RunMenu(blogChoice);
					break;

				case 0:
					Environment.Exit(0);
					break;
			}
		}

		private static Blog GetBlogChoice()
		{
			int chosenBlogNumber;
			while (!int.TryParse(Console.ReadLine(), out chosenBlogNumber) || chosenBlogNumber < 0 || chosenBlogNumber > _blogs.Count)
			{
				Console.WriteLine("Please try with an integer 0-" + _blogs.Count + ".");
			}

			if (chosenBlogNumber != 0)
			{
				return _blogs.Where(b => _blogs.IndexOf(b) == chosenBlogNumber - 1).Single();
			}

			return null;
		}

		private static void MenuBlogList()
		{
			Console.Clear();
			ColorScheme.Header1("Your blogs");
			Console.WriteLine();

			int i;
			for (i = 0; i < _blogs.Count; i++)
			{
				Console.WriteLine("(" + (i + 1) + ") " + _blogs[i].Name);
			}
			Console.WriteLine("(" + i + ") ");
			Console.WriteLine("(0) Quit");
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
