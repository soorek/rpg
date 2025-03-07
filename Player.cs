using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    internal class Player : CharacterExp
    {
        public int Expirience { get; private set; }

        public Player(string name, int health, int attackPower, int level)
            :base(name, health, attackPower, level)
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ваш уровень: {Level} \n" +
                $"Текущий опыт: {(int)Experience} / {(int)ExperienceRequired} \n" +
                $"Здоровье: {Health} \n" +
                $"Базовый урон: {AttackPower}");
        }


    }
}
