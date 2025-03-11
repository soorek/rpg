using rpg.Engine.Skills;

namespace rpg.Entities
{
    internal abstract class Character
    {
        public abstract string Name { get; }
        public abstract Attributes Attributes { get; }



        public void TakeDamage(double damage)
        {

            if (damage < 0) return;

            Attributes.Health -= damage;
            Console.WriteLine($"{Name} получил {damage} урона. Осталось здоровья: {Attributes.Health}");

            if (Attributes.Health <= 0)
            {
                Console.WriteLine($"{Name} погиб.");
                Attributes.Health = 0;
            }
        }

        public void Attack(Character target)
        {

            Console.WriteLine($"{Name} атакует {target.Name} и наносит {Attributes.AttackPower} урона");
            target.TakeDamage(Attributes.AttackPower);
           
        }

        public bool IsAlive()
        {
            return Attributes.Health > 0 ? true : false;
        }
    }
}
