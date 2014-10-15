using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class MenuListOfBlogs
	{
		public static void Show(List<Blog> blogs)
		{
			Console.Clear();
			ColorScheme.Header1("Your blogs");
			Console.WriteLine();

			int i;
			for (i = 0; i < blogs.Count; i++)
			{
				Console.WriteLine("(" + (i + 1) + ") " + blogs[i].Name);
			}

			Console.WriteLine();
			Console.WriteLine("(" + (i+1) + ") Return to start menu");
			Console.WriteLine("(0) Quit");
		}
	}
}
