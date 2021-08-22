using System;
using Asteroids.Models;
using Asteroids.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Data
{
    class EnemyFactory : AbstractFactory<IEnemyModel,IPool>
    {
        private IEnemyData _data;

        public EnemyFactory(IDataLoader dataLoader) : base(dataLoader)
        {

        }
        public void Init(EnemyType type)
        {
            _data = _dataLoader.LoadEnemy(type);
        }
        public override IEnemyModel GetModel() => new EnemyModel(_data.Type, _data.MaxHealth, _data.Damage, _data.Speed);
        public override IPool GetView() => new Pool(_data.Prefab.GetComponent<IPoolObject>());
    }
}
