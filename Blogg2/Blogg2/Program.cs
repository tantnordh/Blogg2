using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			ColorScheme.General();
			Console.WindowHeight = Console.WindowHeight * 3 / 2;

			List<Blog> blogs = new List<Blog>();
			BlogProgram.Run(blogs);
		}
	}
}

