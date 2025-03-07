using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal abstract class CharacterExp : Character
    {

        public CharacterExp(string name, int health, int attackPower, int level)
            : base(name, health, attackPower, level)
        {
        }

        protected const double GROWTH_FACTOR = 0.3;
        protected const int BASE_EXPERIENCE = 100;
        public double Experience { get; protected set; }

        public void AddExp(int exp)
        {
            double ExpRequired = BASE_EXPERIENCE * (Math.Pow(Level,2) * GROWTH_FACTOR);
            Experience += exp;

            if(Experience > ExpRequired)
            {
                Level++;
                Experience -= ExpRequired;
            }
        }
    }
}
