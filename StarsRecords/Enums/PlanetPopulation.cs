using EnumerationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Enums
{
    class PlanetPopulation : RollTableEnumeration
    {
        public static readonly PlanetPopulation FailedColony =
            new PlanetPopulation(1, "Failed colony", 2);

        public static readonly PlanetPopulation Outpost =
            new PlanetPopulation(2, "Outpost", 3);

        public static readonly PlanetPopulation TensOfThousands =
            new PlanetPopulation(3, "Tens of thousands of inhabitants", 4, 5);

        public static readonly PlanetPopulation HundredsOfThousands =
            new PlanetPopulation(4, "Hundreds of thousands of inhabitants", 6, 8);

        public static readonly PlanetPopulation Millions =
            new PlanetPopulation(5, "Millions of inhabitants", 9, 10);

        public static readonly PlanetPopulation Billions =
            new PlanetPopulation(6, "Billions of inhabitants", 11);

        public static readonly PlanetPopulation Alien =
            new PlanetPopulation(7, "Alien civilization", 12);

        private PlanetPopulation() { }
        private PlanetPopulation(int value, string name, int roll) : base(value, name, roll) { }
        private PlanetPopulation(int value, string name, int minRoll, int maxRoll) : base(value, name, minRoll, maxRoll) { }
    }
}
