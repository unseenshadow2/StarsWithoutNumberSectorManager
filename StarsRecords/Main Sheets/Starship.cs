using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Main_Sheets
{
    public enum StarshipHullClass { Fighter, Frigate, Capital };

    /// <summary>
    /// Leave this for later. If I need it, come back to it.
    /// </summary>
    class Starship
    {
        public string name;
        public string hullType;
        public int cost;
        public int armorClass;
    }
}
