using rpg.Engine;
using rpg.Engine.Skills;
using rpg.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Attributes playerAttributes = new Attributes();

        playerAttributes.Health = 1000;
        playerAttributes.AttackPower = 100;

        Player actor = new("ахуевший уебан", playerAttributes);
        EnemyGenerator generator = new(actor);

        for (int i = 0; i < 10; i++)
        {
            Enemy enemy = generator.GetNextEnemy();
            while (enemy.IsAlive())
            {
                actor.Attack(enemy);
            } 
        }
    }
}