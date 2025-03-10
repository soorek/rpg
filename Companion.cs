using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Companion : Character, ILeveling
    {

        public Companion(string name, int health, int attackPower, int level)
            :base(name, health, attackPower, level)
        {
        }

        public void AddExp(int exp)
        {

        }

        public void AddLevel()
        {

        }

    }
}
