using System;
using Asteroids.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;

namespace Asteroids.Data
{
    class EnemyInitializer : IEnemyInitializer
    {
        private IDataLoader _dataLoader;
        private PoolSet<EnemyType> _pool;
        private Dictionary<EnemyType, IEnemyModel> _models;

        public EnemyInitializer(IDataLoader dataLoader = null)
        {
            _dataLoader = dataLoader;
            _pool = new PoolSet<EnemyType>();
            _models = new Dictionary<EnemyType, IEnemyModel>();
        }

        public IEnemyInitializer Init(EnemyType type)
        {
            var data = _dataLoader.LoadEnemy(type);
            var pool = new Pool(data.Prefab.GetComponent<IPoolObject>());
            _pool.Add(type, pool);
            _models.Add(type, new EnemyModel(data.Type, data.MaxHealth, data.Damage, data.Speed));
            return this;
        }

        public IPoolSet<EnemyType> GetViewsPool() => _pool;
        public Dictionary<EnemyType, IEnemyModel> GetModels() => _models;
    }
}
