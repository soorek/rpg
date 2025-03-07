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
        public double ExperienceRequired => BASE_EXPERIENCE * (Math.Pow(Level, 2) * GROWTH_FACTOR);

        public void AddExp(int exp)
        {
            Experience += exp;

            if(Experience > ExperienceRequired)
            {
                Experience -= ExperienceRequired;
                AddLevel();
            }
        }

        private void AddLevel()
        {
            Level++;
           
            ChoiceAttribute("Вы повысили уровень, выберите навык для улучшения " +
                "hp / dmg");
           
        }

        private void ChoiceAttribute(string message)
        {
            Console.WriteLine(message);

            string? choice = Console.ReadLine()?.ToLower();  // Получаем выбор пользователя
            switch (choice)
            {
                case "dmg":
                    AttackPower += 20;
                    Console.WriteLine($"Attack Power increased to {AttackPower}");
                    break;

                case "hp":
                    Health += 100;
                    Console.WriteLine($"Health increased to {Health}");
                    break;

                default:
                    ChoiceAttribute("Invalid choice, try again.");  // Повторный вызов, если выбор неверный
                    break;
            }
        }
    }
}
