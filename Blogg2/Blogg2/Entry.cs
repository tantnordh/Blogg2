using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
	public class Entry
	{
		public DateTime Date { get; set; }
		public string Text { get; set; }

		public Entry(DateTime date, string text)
		{
			Date = date;
			Text = text;
		}
	}
}
