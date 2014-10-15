using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class CreateTestEntries
	{
		private static Blog _blog;

		public Blog GetBlog()
		{
			return _blog;
		}

		public CreateTestEntries(Blog blog)
		{
			Post testPost;
			DateTime date = DateTime.Today.AddDays(-25);
			string text;
			string title;
			for (int i = 1; i <= 25; i++)
			{
				date = date.AddDays(1);
				text = "Textinlägg nummer " + i;
				title = "Titel " + i;
				testPost = new Post(date, text, title);
				blog.Posts.Add(testPost);
			}

			_blog = blog;
		}
	}
}