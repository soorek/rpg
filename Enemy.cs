using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Enemy : Character
    {

        public Enemy(string name, int health, int attackPower, int level)
            :base(name, health, attackPower, level) { }

    }
}
