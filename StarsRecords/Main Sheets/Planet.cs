using StarsRecords.Main_Sheets;
using StarsRecords.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarsRecords.Supporting_Sheets;

namespace StarsRecords.Main_Sheets
{
    public class Planet
    {
        public int id { get; set; }
        public string name { get; set; }
		public int locX { get; set; }
		public int locY { get; set; }
        public string enemies { get; set; }
        public string friends { get; set; }
        public string complications { get; set; }
        public string places { get; set; }
        public string things { get; set; }
        public string capitalAndGovernment { get; set; }
        public string culturalNotes { get; set; }
        public string partyActivities { get; set; }
        public string notes { get; set; }
        public string tags { get; set; }
        public string population { get; set; }
        public string techLevel { get; set; }
        public string atmosphere { get; set; }
        public string temperature { get; set; }
        public string biosphere { get; set; }
		public bool gmDrawOnly { get; set; }

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
