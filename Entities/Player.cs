using rpg.Engine;
using rpg.Engine.Skills;

namespace rpg.Entities
{
    internal class Player : Character, ILeveling
    {

        public double Experience { get; protected set; }
        public double ExperienceRequired => GameSettings.BASE_EXPERIENCE * (Math.Pow(Attributes.Level, 2) * GameSettings.GROWTH_FACTOR);

        public override string Name => _name;

        private readonly Attributes _attributes;
        public override Attributes Attributes => _attributes;

        private readonly string _name;

        public Player(string name, Attributes attributes)
        {
            _name = name;
            _attributes = attributes;
        }



        public void ShowInfo()
        {
            Console.WriteLine($"Ваш уровень: {Attributes.Level} \n" +
                $"Текущий опыт: {(int)Experience} / {(int)ExperienceRequired} \n" +
                $"Здоровье: {Attributes.Health} \n" +
                $"Базовый урон: {Attributes.AttackPower}");
        }

        private void ChoiceAttribute(string message)
        {
            Console.WriteLine(message);

            string? choice = Console.ReadLine()?.ToLower();
            switch (choice)
            {
                case "dmg":
                    Attributes.AttackPower += 20;
                    Console.WriteLine($"Сила атаки увеличина на {Attributes.AttackPower}");
                    break;

                case "hp":
                    Attributes.Health += 100;
                    Console.WriteLine($"Здоровье увеличино на {Attributes.Health}");
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
            Attributes.Level++;

            ChoiceAttribute("Вы повысили уровень, выберите навык для улучшения " +
                "hp / dmg");

        }

    }
}
