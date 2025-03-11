using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Entities.Enemies
{
    internal class Rat : Enemy
    {
        public Rat(string name, int health, int attackPower, int level)
          : base(name, health, attackPower, level) { }

    }
}
