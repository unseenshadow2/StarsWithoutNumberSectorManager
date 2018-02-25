using EnumerationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Enums
{
    public class PlanetAtmosphere : RollTableEnumeration
    {
        public static readonly PlanetAtmosphere Corrosive = 
            new PlanetAtmosphere(0, "Corrosive", 2);

        public static readonly PlanetAtmosphere InertGas =
            new PlanetAtmosphere(1, "Inert Gas", 3);

        public static readonly PlanetAtmosphere AirlessThin =
            new PlanetAtmosphere(2, "Airless or thin", 4);

        public static readonly PlanetAtmosphere Breathable =
            new PlanetAtmosphere(3, "Breathable mix", 5, 9);

        public static readonly PlanetAtmosphere Thick =
            new PlanetAtmosphere(4, "Thick, breathable with a pressure mask", 10);

        public static readonly PlanetAtmosphere Invasive =
            new PlanetAtmosphere(5, "Invasive, toxic", 11);

        public static readonly PlanetAtmosphere CorrosiveInvasive =
            new PlanetAtmosphere(6, "Corrosive and invasive atmosphere", 12);

        private PlanetAtmosphere() { }
        private PlanetAtmosphere(int value, string name, int roll) : base(value, name, roll) { }
        private PlanetAtmosphere(int value, string name, int minRoll, int maxRoll) : base(value, name, minRoll, maxRoll) { }
    }
}
