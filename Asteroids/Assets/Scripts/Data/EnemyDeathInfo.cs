namespace Asteroids.Data
{
    public struct EnemyDeathInfo
    {
        public EnemyType Type;
        public int Score;

        public EnemyDeathInfo(EnemyType type, int score)
        {
            Type = type;
            Score = score;
        }
    }
}
