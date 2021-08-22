using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;

namespace Asteroids.Data
{
    internal interface IEnemyInitializer
    {
        public IEnemyInitializer Init(EnemyType type);
        public IPoolSet<EnemyType> GetViewsPool();
        public Dictionary<EnemyType, IEnemyModel> GetModels();
    }
}
