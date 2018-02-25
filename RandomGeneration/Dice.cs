
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGeneration
{
    public static class Dice
    {
        private static Random _random = new Random();

        public static int RollDie(int die)
        {
            return _random.Next(1, die + 1);
        }

        public static int RollD6()
        {
            return RollDie(6);
        }

        public static int Roll2D6()
        {
            return RollD6() + RollD6();
        }
    }
}
