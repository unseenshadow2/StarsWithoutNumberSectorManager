using EnumerationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Enums
{
    public class PlanetBiosphere : RollTableEnumeration
    {
        public static readonly PlanetBiosphere Remnants =
            new PlanetBiosphere(1, "Remnants", 2);

        public static readonly PlanetBiosphere Microbial =
            new PlanetBiosphere(2, "Microbial life", 3);

        public static readonly PlanetBiosphere NoNative =
            new PlanetBiosphere(3, "No native", 4, 5);

        public static readonly PlanetBiosphere HumanMiscible =
            new PlanetBiosphere(4, "Human-miscible", 6, 8);

        public static readonly PlanetBiosphere Immiscible =
            new PlanetBiosphere(5, "Immiscible", 9, 10);

        public static readonly PlanetBiosphere Hybrid =
            new PlanetBiosphere(6, "Hybrid", 11);

        public static readonly PlanetBiosphere Engineered =
            new PlanetBiosphere(7, "Engineered", 12);

        private PlanetBiosphere() { }
        private PlanetBiosphere(int value, string name, int roll) : base(value, name, roll) { }
        private PlanetBiosphere(int value, string name, int minRoll, int maxRoll) : base(value, name, minRoll, maxRoll) { }
    }
}
