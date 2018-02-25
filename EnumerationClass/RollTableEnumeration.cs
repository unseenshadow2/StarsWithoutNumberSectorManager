using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationClass
{
    public abstract class RollTableEnumeration : Enumeration
    {
        private readonly int _rangeMin;
        private readonly int _rangeMax;

        public int RangeMin { get { return _rangeMin; } }
        public int RangeMax { get { return _rangeMax; } }

        protected RollTableEnumeration() { }
        protected RollTableEnumeration(int value, string name, int roll) : base(value, name)
        {
            _rangeMin = roll;
            _rangeMax = roll;
        }

        protected RollTableEnumeration(int value, string name, int minRoll, int maxRoll) : base(value, name)
        {
            _rangeMin = minRoll;
            _rangeMax = maxRoll;
        }

        public bool IsWithinRange(int number)
        {
            //if ((number >= _rangeMin) && (number <= RangeMax)) return true;
            //else return false;

            return ((number >= _rangeMin) && (number <= RangeMax));
        }
    }
}
