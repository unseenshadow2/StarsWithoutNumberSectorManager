using EnumerationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Enums
{
    public class PlanetTemperature : RollTableEnumeration
    {
        public static readonly PlanetTemperature Frozen =
            new PlanetTemperature(1, "Frozen", 2);

        public static readonly PlanetTemperature VariableCold =
            new PlanetTemperature(2, "Variable cold-to-temperate", 3);

        public static readonly PlanetTemperature Cold =
            new PlanetTemperature(3, "Cold", 4, 5);

        public static readonly PlanetTemperature Temperate =
            new PlanetTemperature(4, "Temperate", 6, 8);

        public static readonly PlanetTemperature Warm =
            new PlanetTemperature(5, "Warm", 9, 10);

        public static readonly PlanetTemperature VariableWarm =
            new PlanetTemperature(6, "Variable temperate-to-warm", 11);

        public static readonly PlanetTemperature Burning =
            new PlanetTemperature(7, "Burning", 12);

        private PlanetTemperature() { }
        private PlanetTemperature(int value, string name, int roll) : base(value, name, roll) { }
        private PlanetTemperature(int value, string name, int minRoll, int maxRoll) : base(value, name, minRoll, maxRoll) { }
    }
}
