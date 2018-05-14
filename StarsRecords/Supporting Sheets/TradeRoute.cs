using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Supporting_Sheets
{
	public class TradeRoute
	{
		public int id { get; set; }
		public int star1X { get; set; }
		public int star1Y { get; set; }
		public int star2X { get; set; }
		public int star2Y { get; set; }
		public bool gmDrawOnly { get; set; }

		public string display
		{
			get
			{
				return String.Format("0{0}0{1} to 0{2}0{3}", star1X, star1Y, star2X, star2Y);
			}
		}
	}
}
