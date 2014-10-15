using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class MenuStart
	{
		public static void Show()
		{
			Console.Clear();
			ColorScheme.Header1("START MENU");
			Console.WriteLine();
			ColorScheme.General();
			Console.WriteLine("(1) Create new blog");
			Console.WriteLine("(2) Choose blog");
			Console.WriteLine();
			Console.WriteLine("(0) Quit");
			Console.WriteLine();
		}
	}
}
