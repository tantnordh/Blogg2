using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class HandleChoiceOfBlog
	{
		public static Blog GetChosenBlog(List<Blog> blogs)
		{
			int chosenBlogNumber;
			while (!int.TryParse(Console.ReadLine(), out chosenBlogNumber) || chosenBlogNumber < 0 || chosenBlogNumber > blogs.Count + 1)
			{
				Console.WriteLine("Please try with an integer 0-" + (blogs.Count + 1) + ".");
			}

			if (chosenBlogNumber < 1 && chosenBlogNumber <= blogs.Count)
			{
				return blogs.Where(b => blogs.IndexOf(b) == chosenBlogNumber - 1).Single();
			}
			else if (chosenBlogNumber > blogs.Count)
			{
				ProgramBlog.Run(blogs);
			}

			return null;
		}
	}
}
