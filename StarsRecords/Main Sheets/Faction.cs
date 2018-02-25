using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Main_Sheets
{
    public class Faction
    {
        public int id { get; set; }
        public string name { get; set; }
        public string income { get; set; }
        public string homeworld { get; set; }
        public string factionTags { get; set; }
        public string goalProgress { get; set; }
        public string historyAndPurpose { get; set; }
        public string partyInvolvement { get; set; }
        public string notes { get; set; }
        public int currentFacCreds { get; set; }
        public int forceScore { get; set; }
        public int cunningScore { get; set; }
        public int wealthScore { get; set; }
        public int currentHp { get; set; }
        public int maxHp { get; set; }
        public ICollection<NPC> npcs { get; set; }
        public ICollection<FactionAsset> assets { get; set; }
    }
}
