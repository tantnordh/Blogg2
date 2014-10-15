using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class HandleMainMenuChoice
	{
		private static int _choice;

		public static int GetChoice()
		{
			return _choice;
		}

		public static void HandleChoice(Blog blog)
		{
			_choice = ChoiceMaker();

			List<Post> posts = blog.Posts.OrderBy(p => p.Date).ToList();
			PostManager postManager = new PostManager(blog);

			switch (_choice)
			{
				case 1:
					// Create posts
					postManager.CreatePost();
					break;

				case 2:
					// Show all posts
					Print.AllPosts(posts);
					HandlePostChoice.HandleChoice(posts);
					Console.ReadLine();
					//HandlePostChoice();
					break;

				case 3:
					// Show post titles
					break;

				case 4:
					// Search post via title
					break;

				case 5:
					// Search post via date
					break;

				case 6:
					// Search post via tag
					break;

				case 7:
					ProgramBlog.Run(ProgramBlog.GetBlogList());
					break;

				case 0:
					Environment.Exit(0);
					break;
			}
		}

		private static int ChoiceMaker()
		{
			Console.WriteLine();
			Console.WriteLine("Choose an alternative: ");
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 7)
			{
				Console.WriteLine("Please try with an integer 0-7.");
			}

			return choice;
		}
	}
}
