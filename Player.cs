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
            Expirience = 0;
        }

        private void LevelUp(int exp)
        {
            Level++;
            Console.WriteLine("Вы повысили уровень, выберите навык для улучшения " +
                "hp / dmg");
            if(Console.ReadLine() == "hp")
            {
                Health += 100;
                Console.WriteLine("Ваше здоровье увеличено на 100!");
            }
            else if(Console.ReadLine() == "dmg")
            {
                AttackPower += 20;
                Console.WriteLine("Урон увеличен на 20 единиц");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ваш уровент: {Level} \n" +
                $"Текущий опыт: {Expirience} / {ExperienceRequired} \n" +
                $"Здоровье: {Health} \n" +
                $"Базовый урон: {AttackPower}");
        }


    }
}
