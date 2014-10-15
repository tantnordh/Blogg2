using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class ColorScheme
	{
		public static void General()
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.DarkGray;
		}

		public static void Header1(string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(text.ToUpper());
			General();
		}

		public static void Header2(string text)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(text.ToUpper());
			General();
		}
	}
}
