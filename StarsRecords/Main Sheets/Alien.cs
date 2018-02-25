using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Main_Sheets
{
    // TODO: Turn this into a more advanced version of enum
    public enum BodyType { Humanlike, Avian, Reptilian, Insectile, Exotic, Hybrid };

    public class Alien
    {
        public int id { get; set; }
        public string name { get; set; }
        public string plural { get; set; }
        public string homeworld { get; set; }
        public string lenses { get; set; }
        public string appearance { get; set; }
        public string government { get; set; }
        public string goals { get; set; }
        public string adventureHooks { get; set; }
        public string notes { get; set; }
        public string bodyType { get; set; }
        public ICollection<NPC> enemies { get; set; }
    }
}
