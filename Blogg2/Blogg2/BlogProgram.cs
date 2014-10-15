using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class BlogProgram
	{
		private static List<Blog> _blogs;

		public static List<Blog> GetBlogList()
		{
			return _blogs;
		}

		public static void Run(List<Blog> blogs)
		{
			_blogs = blogs;

			MenuStart.Show();
			HandleStartMenuChoice.HandleChoice(_blogs);
		}
	}
}

