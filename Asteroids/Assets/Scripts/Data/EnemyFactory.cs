using System;
using Asteroids.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;

namespace Asteroids.Data
{
    internal class EnemyFactory : AbstractFactory<IEnemyModelSet,IPoolSet<EnemyType>>
    {
        private PoolSet<EnemyType> _poolSet;
        private EnemyModelSet _models;

        public EnemyFactory(IDataLoader dataLoader) : base(dataLoader)
        {
            _poolSet = new PoolSet<EnemyType>();
            _models = new EnemyModelSet();
        }

        public  void Init(EnemyType type)
        {
            var data = _dataLoader.LoadEnemy(type);
            var pool = new Pool(data.Prefab.GetComponent<IPoolObject>());
            _poolSet.Add(type, pool);
            _models.Add(type, new EnemyModel(data.Type, data.MaxHealth, data.Damage, data.Speed));
        }

        public override IPoolSet<EnemyType> GetView() => _poolSet;
        public override IEnemyModelSet GetModel() => _models;
    }
}
