using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Entities
{
    internal class Player : Character, ILeveling
    {

        public double Experience { get; protected set; }
        public double ExperienceRequired => GameSettings.BASE_EXPERIENCE * (Math.Pow(Level, 2) * GameSettings.GROWTH_FACTOR);

        public Player(string name, int health, int attackPower, int level)
            : base(name, health, attackPower, level)
        {
        }



        public void ShowInfo()
        {
            Console.WriteLine($"Ваш уровень: {Level} \n" +
                $"Текущий опыт: {(int)Experience} / {(int)ExperienceRequired} \n" +
                $"Здоровье: {Health} \n" +
                $"Базовый урон: {AttackPower}");
        }

        private void ChoiceAttribute(string message)
        {
            Console.WriteLine(message);

            string? choice = Console.ReadLine()?.ToLower();
            switch (choice)
            {
                case "dmg":
                    AttackPower += 20;
                    Console.WriteLine($"Сила атаки увеличина на {AttackPower}");
                    break;

                case "hp":
                    Health += 100;
                    Console.WriteLine($"Здоровье увеличино на {Health}");
                    break;

                default:
                    ChoiceAttribute("Не верный выбор. Укажите hp или dmg, попробуйте ещё раз.");  // Повторный вызов, если выбор неверный
                    break;
            }
        }

        public void AddExp(int exp)
        {
            Experience += exp;

            if (Experience > ExperienceRequired)
            {
                Experience -= ExperienceRequired;
                AddLevel();
            }
        }

        public void AddLevel()
        {
            Level++;

            ChoiceAttribute("Вы повысили уровень, выберите навык для улучшения " +
                "hp / dmg");

        }

    }
}
