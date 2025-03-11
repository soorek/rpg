using rpg.Entities;
using rpg.Entities.Enemies;

namespace rpg.Engine
{
    internal class EnemyGenerator
    {

        private readonly Player _player;
        private readonly Random _random = new Random();

        public EnemyGenerator(Player player)
        {
            _player = player;
        }


        public Enemy GetNextEnemy()
        {
            int RandomLevel = _random.Next(-3, 4) + _player.Attributes.Level;
            return GetRandom(RandomLevel);

        }

        private Enemy GetRandom(int level)
        {
            EnemyTypes number = (EnemyTypes)_random.Next(0, 4);
            return number switch
            {
                EnemyTypes.Bandit => new Bandit(level),
                EnemyTypes.Goblin => new Goblin(level),
                EnemyTypes.Rat => new Rat(level),
                EnemyTypes.Slime => new Slime(level),
                _ => throw new NotImplementedException()
            };

        }


    }
}
