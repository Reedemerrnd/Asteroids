using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    //implement dispose removelisteners
    class SpawnedPoolObjectsList<T>: ISpawnedGameObjectsList where T : Enum
    {
        private List<GameObject> _list;

        public IEnumerable<GameObject> GameObjects => _list;

        public SpawnedPoolObjectsList(IPoolSet<T> poolSet)
        {
            _list = new List<GameObject>();
            var pools = poolSet.GetActivePools();
            foreach (var item in pools)
            {
                if(item is IPoolItemAdded pool)
                {
                    pool.OnPoolElementAdded += Add;
                }
            }
        }
        private void Add(GameObject obj)
        {
            _list.Add(obj);
        }

       
    }
}
