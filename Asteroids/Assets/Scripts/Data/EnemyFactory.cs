﻿using System;
using Asteroids.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;

namespace Asteroids.Data
{
    internal class EnemyFactory : IFactory<IEnemyModelSet,IPoolSet<EnemyType>>
    {
        private PoolSet<EnemyType> _poolSet;
        private EnemyModelSet _models;
        private IEnemyLoader _dataLoader;

        public EnemyFactory(IEnemyLoader dataLoader)
        {
            _dataLoader = dataLoader;
            _poolSet = new PoolSet<EnemyType>();
            _models = new EnemyModelSet();
        }

        public  void Init(EnemyType type)
        {
            var data = _dataLoader.LoadEnemy(type);
            data.Prefab.GetComponent<IInjectable<IMoveVariant>>().Inject(new OneAxisMove());
            var pool = new Pool(data.Prefab.GetComponent<IPoolObjectPrototype>());
            _poolSet.Add(type, pool);
            _models.Add(type, new EnemyModel(data.Type, data.MaxHealth, data.Damage, data.Speed));
        }

        public IPoolSet<EnemyType> GetView() => _poolSet;
        public IEnemyModelSet GetModel() => _models;
    }
}
