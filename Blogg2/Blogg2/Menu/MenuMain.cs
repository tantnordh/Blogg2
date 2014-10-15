using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class MainMenu
	{
		private static Blog _blog;

		public static void RunMenu(Blog blog)
		{
			_blog = blog;

			int choice = -1;
			while (choice != 0 && blog != null)
			{
				Show();
				HandleMainMenuChoice.HandleChoice(blog);
				HandleMainMenuChoice.GetChoice();
			}
		}

		private static void Show()
		{
			Console.Clear();
			ColorScheme.Header1("menu:" + _blog.Name);
			Console.WriteLine();
			ColorScheme.General();
			Console.WriteLine("(1) Create post");
			Console.WriteLine("(2) Show all posts");
			Console.WriteLine("(3) Show post titles");
			Console.WriteLine("(4) Search post via title");
			Console.WriteLine("(5) Search post via date");
			Console.WriteLine("(6) Search post via tag");

			Console.WriteLine("(7) Go to start menu");
			Console.WriteLine();
			Console.WriteLine("(0) Save & Quit");
		}
	}
}
