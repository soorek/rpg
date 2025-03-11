using rpg.Engine.Skills;

namespace rpg.Entities
{
    internal abstract class Enemy : Character
    {

        private Attributes _attributes;
        public override Attributes Attributes => _attributes;

        protected abstract double BaseHealth { get; }
        protected abstract double BaseAttackPower { get; }
        protected abstract double BaseMana { get; }
        protected abstract double BaseStamina { get; }
        protected abstract double BaseArmor { get; }
        protected abstract double BaseEvasion { get; }

        protected abstract double HealthModify { get; }
        protected abstract double AttackPowerModify { get; }
        protected abstract double ManaModify { get; }
        protected abstract double StaminaModify { get; }
        protected abstract double ArmorModify { get; }
        protected abstract double EvasionModify { get; }


        public Enemy(int level)
        {
            _attributes = new Attributes()
            {
                Level = level,
                Health = BaseHealth * level * HealthModify,
                AttackPower = BaseAttackPower * level * AttackPowerModify,
                Mana = BaseMana * level * ManaModify,
                Stamina = BaseStamina * level * StaminaModify,
                Armor = BaseArmor * level * ArmorModify,
                Evasion = BaseEvasion * level * EvasionModify

            };
        }
    }
}
