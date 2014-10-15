using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class PostManager
	{
		private Blog _blog;

		public Blog GetBlog()
		{
			return _blog;
		}

		public void CreatePost()
		{
			Console.Clear();
			ColorScheme.Header1("new post");
			Console.WriteLine();
			DateTime date = DateTime.Today;
			Console.WriteLine("Enter title: ");
			string title = Console.ReadLine();
			Console.WriteLine("Enter text: ");
			string text = Console.ReadLine();

			Post newPost = new Post(date, text, title);

			Console.WriteLine("Enter tags or leave empty, separate by comma: ");
			newPost.Tags = new List<string>(Console.ReadLine().Split(',', ' '));

			_blog.Posts.Add(newPost);
		}

		public PostManager(Blog blog)
		{
			_blog = blog;
		}
	}
}
