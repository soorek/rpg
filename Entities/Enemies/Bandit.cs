using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Entities.Enemies
{
    internal class Bandit : Enemy
    {

        public Bandit(string name, int health, int attackPower, int level)
            : base(name, health, attackPower, level) { }



    }
}
