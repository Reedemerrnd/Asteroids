using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Asteroids.Data
{
    internal class SerializableEnemyData
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public EnemyType Type;
        public int Health;
        public int Damage;
        public float Speed;
    }
}
