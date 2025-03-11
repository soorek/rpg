using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Entities
{
    internal abstract class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int AttackPower { get; protected set; }
        public int Level { get; protected set; }

        public Character(string name, int health, int attackPower, int level)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Level = level;
        }

        public void TakeDamage(int damage)
        {

            if (damage < 0) return;

            Health -= damage;
            Console.WriteLine($"{Name} получил {damage} урона. Осталось здоровья: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine($"{Name} погиб.");
                Health = 0;
            }
        }

        public void Attack(Character target)
        {


            target.TakeDamage(AttackPower);
            Console.WriteLine($"{Name} атакует {target.Name} и наносит {AttackPower} урона");
        }

        public bool IsAlive()
        {
            return Health > 0 ? true : false;
        }
    }
}
