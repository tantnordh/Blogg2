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
			ColorScheme.Header1("menu: your blogs");
			Console.WriteLine();
			ColorScheme.General();

			int i;
			for (i = 0; i < blogs.Count; i++)
			{
				Console.WriteLine("(" + (i + 1) + ") " + blogs[i].Name);
			}

			Console.WriteLine("(" + (i + 1) + ") Return to start menu");
			Console.WriteLine();
			Console.WriteLine("(0) Quit");
		}
	}
}
