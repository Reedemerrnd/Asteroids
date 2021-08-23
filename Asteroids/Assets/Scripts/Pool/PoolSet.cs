using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    public class PoolSet<T> : IPoolSet<T> where T : Enum
    {
        private Dictionary<T, IPool> _set;

        public PoolSet()
        {
            _set = new Dictionary<T, IPool>();
        }
        public void Add(T type, IPool pool)
        {
            _set.Add(type, pool);
        }


        public IPool[] GetActivePools() => _set.Values.ToArray();
        public bool TryGetItem(T type, out GameObject item)
        {
            if (_set.ContainsKey(type))
            {
                item = _set[type].GetItem().Self;
                return true;
            }
            item = null;
            return false;
        }
        public bool TryGetItem<K>(T type, out K item)
        {
            TryGetItem(type, out var result);
            return result.TryGetComponent<K>(out item);
        }
    }
}
