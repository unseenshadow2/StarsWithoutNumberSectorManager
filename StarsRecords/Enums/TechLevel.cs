using EnumerationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsRecords.Enums
{
    public class TechLevel : RollTableEnumeration
    {
        public static readonly TechLevel Tech0 =
            new TechLevel(1, "Tech level 0. Stone-age technology.", 2);

        public static readonly TechLevel Tech1 =
            new TechLevel(2, "Tech level 1. Medieval technology.", 3);

        public static readonly TechLevel Tech2 =
            new TechLevel(3, "Tech level 2. Nineteenth-century technology.", 4);

        public static readonly TechLevel Tech3 =
            new TechLevel(4, "Tech level 3. Twentieth-century technology.", 5, 6);

        public static readonly TechLevel Tech4 =
            new TechLevel(5, "Tech level 4. Baseline postech.", 7, 10);

        public static readonly TechLevel Tech4Plus =
            new TechLevel(6, "Tech level 4 with specialties or some surviving pretech.", 11);

        public static readonly TechLevel Tech5 =
            new TechLevel(7, "Tech level 5. Pretech, pre-Silence technology.", 12);

        private TechLevel() { }
        private TechLevel(int value, string name, int roll) : base(value, name, roll) { }
        private TechLevel(int value, string name, int minRoll, int maxRoll) : base(value, name, minRoll, maxRoll) { }
    }
}
