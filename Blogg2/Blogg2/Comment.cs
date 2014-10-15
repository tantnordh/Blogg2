using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class Comment : Entry
	{
		private static int _commentNumber = 0;

		public string Name { get; set; }
		public int Id { get; set; }

		public Comment(DateTime date, string text, string name)
			: base(date, text)
		{
			Name = name;
			Text = text;
			Date = date;
			Id = _commentNumber;
			_commentNumber++;
		}
	}
}
