namespace rpg.Engine.Skills
{
    internal class Attributes
    {
        private int _level;
        public int Level
        {
            get => _level;
            set => _level = value < 0 ? 1 : value;

        }
        public double Health { get; set; }
        public double AttackPower { get; set; }
        public double Mana { get; set; }
        public double Stamina { get; set; }
        public double Armor { get; set; }
        public double Evasion { get; set; }

    }
}
