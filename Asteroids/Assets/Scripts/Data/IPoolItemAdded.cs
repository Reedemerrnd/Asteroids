using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    public interface IPoolItemAdded
    {
        public event Action<GameObject> OnPoolElementAdded;
    }
}
