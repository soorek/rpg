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

        private void AddLevel()
        {
            Level++;
           
            Console.WriteLine("Вы повысили уровень, выберите навык для улучшения " +
                "hp / dmg");
            if (Console.ReadLine() == "hp")
            {
                Health += 100;
                Console.WriteLine("Ваше здоровье увеличено на 100!");
            }
            else if (Console.ReadLine() == "dmg")
            {
                AttackPower += 20;
                Console.WriteLine("Урон увеличен на 20 единиц");
            }
        }

        private void ChoiceAttribute(string message)
        {
            Console.WriteLine(message);

            string choice = Console.ReadLine();  // Получаем выбор пользователя

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
