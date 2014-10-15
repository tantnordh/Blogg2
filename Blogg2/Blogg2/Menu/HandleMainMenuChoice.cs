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
			Console.WriteLine("Choose an alternative: ");
			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 7)
			{
				Console.WriteLine("Please try with an integer 0-7.");
			}

			_choice = choice;

			switch (choice)
			{
				case 1:

					break;

				case 2:

					break;

				case 3:

					break;

				case 4:

					break;

				case 5:

					break;

				case 6:

					break;

				case 7:
					ProgramBlog.Run(ProgramBlog.GetBlogList());
					break;

				case 0:
					Environment.Exit(0);
					break;
			}
		}
	}
}
