using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Supporting_Sheets
{
    public class FactionAsset
    {
        public string name { get; set; }
        public string type { get; set; }
        public string attack { get; set; }
        public string counter { get; set; }
        public string location { get; set; }
        public string notes { get; set; }
        public int maxHealth { get; set; }
        public int currentHealth { get; set; }
        public int id { get; set; }
    }
}
