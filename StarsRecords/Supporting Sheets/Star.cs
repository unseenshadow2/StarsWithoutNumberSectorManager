using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Supporting_Sheets
{
	public class Star
	{
		public int id { get; set; }
		public int locX { get; set; }
		public int locY { get; set; }
		public string name { get; set; }
		public string displayName
		{
			get
			{
				return name + " (" + LocToString() +")";
			}
		}

		/// <summary>
		/// Get the location string from the location stored in the planet.
		/// </summary>
		/// <returns>A Stars Without Number Sector location string</returns>
		public string LocToString()
		{
			string toReturn = String.Format("0{0}0{1}", locX, locY);

			return toReturn;
		}

		/// <summary>
		/// Take a location string and alter the location of the planet.
		/// </summary>
		/// <param name="location">The location string</param>
		public void LocFromString(string location)
		{
			if (location.Length != 4)
			{
				locX = 0;
				locY = 0;
			}
			else
			{
				locX = location[1] - 48;
				locY = location[3] - 48;
			}
		}
	}
}
