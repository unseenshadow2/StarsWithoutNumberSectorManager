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
        public ICollection<Adventure> adventures { get; set; }
        public ICollection<NPC> npcs { get; set; }
        public string population { get; set; }
        public string techLevel { get; set; }
        public string atmosphere { get; set; }
        public string tempurature { get; set; }
        public string biosphere { get; set; }
    }
}
