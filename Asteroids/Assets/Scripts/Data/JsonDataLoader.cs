using Newtonsoft.Json;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Asteroids.Data
{
    internal sealed class JsonDataLoader : IEnemyLoader
    {
        private const string PATH = @"Assets/Resources/Json/EnemyJson.txt";
        private string _file;
        private SerializableEnemyData[] _loadedEnemyDatas;

        public JsonDataLoader()
        {
            _file = File.ReadAllText(PATH);
            _loadedEnemyDatas = JsonConvert.DeserializeObject<SerializableEnemyData[]>(_file);
        }

        public EnemyData LoadEnemy(EnemyType enemyType)
        {
            var result = new EnemyData();
            var cache = _loadedEnemyDatas.FirstOrDefault(o => o.Type == enemyType);

            result.Type = cache.Type;
            result.MaxHealth = cache.Health;
            result.Damage = cache.Damage;
            result.Speed = cache.Speed;
            result.Prefab = Resources.Load<GameObject>(ResourcesPath.Enemies[enemyType]);

            return result;
        }
    }
}
