using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Supporting_Sheets
{
    public class NPC
    {
		public int id { get; set; }
		public string name { get; set; }
        public string health { get; set; }
        public string damage { get; set; }
        public string description { get; set; }
        public string powers { get; set; } // This should normally be left blank
        public string notes { get; set; }
        public string toHit { get; set; }
        public string AC { get; set; }
        public int skillBonus { get; set; }
        public int saves { get; set; }
        public int move { get; set; }
        public int moral { get; set; }
    }
}
