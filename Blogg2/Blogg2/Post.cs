using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class Post : Entry
	{
		private static int _postNumber = 0;

		public string Title { get; set; }
		public List<string> Tags { get; set; }
		public List<Comment> Comments { get; set; }
		public int Id { get; set; }

		public Post(DateTime date, string text, string title)
			: base(date, text)
		{
			Id = _postNumber;
			_postNumber++;
			Text = text;
			Title = title;
			Comments = new List<Comment>();
			Tags = new List<string>();
		}
	}
}
