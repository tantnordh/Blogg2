using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{

	public class Blog
	{
		public List<Post> Posts { get; set; }
		public string Name { get; private set; }

		public Blog(string name)
		{
			Name = name;
			Posts = new List<Post>();
		}
	}
}
