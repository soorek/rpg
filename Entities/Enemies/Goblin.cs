namespace rpg.Entities.Enemies
{
    internal class Goblin : Enemy
    {
        public Goblin(int level) : base(level)
        {
        }

        public override string Name => "Гоблин";

        protected override double HealthModify => 1;
        protected override double AttackPowerModify => 1;
        protected override double ManaModify => 1;
        protected override double StaminaModify => 1;
        protected override double ArmorModify => 1;
        protected override double EvasionModify => 1;

        protected override double BaseHealth => 50;
        protected override double BaseAttackPower => 10;
        protected override double BaseMana => 0;
        protected override double BaseStamina => 100;
        protected override double BaseArmor => 0;
        protected override double BaseEvasion => 0.2;

    }
}
