using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Asteroids.Views;

namespace Asteroids.Data
{
    public interface IPool
    {
        public IPoolObject GetItemAt(Vector3 position, Quaternion rotation);
        public IPoolObject GetItem();
        public void ReturnToPool(IPoolObject item);
    }
}
