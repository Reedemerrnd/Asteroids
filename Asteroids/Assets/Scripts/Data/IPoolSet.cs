using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Data
{
    public interface IPoolSet<T> where T : Enum
    {
        public bool TryGetItem(T Type, out GameObject item);
    }
}
