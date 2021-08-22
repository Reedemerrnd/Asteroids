using Asteroids.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    class EnemyModelSet : IEnemyModelSet
    {
        private Dictionary<EnemyType, IEnemyModel> _set;
        public IEnemyModel this[EnemyType index] => _set[index];
        public int Count => _set.Count;
        public EnemyType[] Keys => _set.Keys.ToArray();

        public EnemyModelSet()
        {
            _set = new Dictionary<EnemyType, IEnemyModel>();
        }
        public void Add(EnemyType type, IEnemyModel model) => _set.Add(type, model);
    }
}
