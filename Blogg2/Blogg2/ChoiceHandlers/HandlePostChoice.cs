using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class HandlePostChoice
	{
		public static void HandleChoice(List<Post> posts)
		{
			Console.WriteLine();
			Console.WriteLine("(0) Back");

			Console.WriteLine("Choose an alternative: ");
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > posts.Count)
			{
				Console.WriteLine("Please try with an integer 0-" + posts.Count);
			}

			if (choice >= 1 && choice <= blogs.Count)
			{
				_chosenBlog = blogs.Where(b => blogs.IndexOf(b) == chosenBlogNumber - 1).Single();
			}
			else
			{
				ProgramBlog.Run(blogs);
			}
		}
	}
}
