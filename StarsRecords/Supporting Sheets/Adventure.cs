using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Main_Sheets
{
    public class Adventure
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string expectedLevels { get; set; }
        public string dateRun { get; set; }
        public string participants { get; set; }
        public string adventureOutline { get; set; }
        public string rewardsAvailable { get; set; }
        public string summaryOfEvents { get; set; }
        public string notes { get; set; }
        public ICollection<NPC> npcs { get; set; }
    }
}
