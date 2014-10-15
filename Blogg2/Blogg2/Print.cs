using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public static class Print
	{
		public static void AllPosts(List<Post> posts)
		{
			posts = posts.OrderBy(p => p.Date).ToList();

			Console.Clear();
			for (int i = 0; i < posts.Count; i++)
			{
				Console.Write("(" + (i + 1) + ") ");
				PostSummary(posts[i]);
				Console.WriteLine();
			}
		}

		public static void PostSummary(Post post)
		{
			ColorScheme.Header1(post.Date.ToShortDateString() + " | " + post.Title);
			Console.WriteLine(post.Text);
		}
	}
}
