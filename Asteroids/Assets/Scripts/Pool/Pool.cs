using System;
using System.Collections.Generic;
using Asteroids.Views;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    internal class Pool : IPool
    {
        IPoolObject _poolObject;

        private Stack<IPoolObject> _poolStack;
        public Pool(IPoolObject poolObject)
        {
            _poolObject = poolObject;
            _poolStack = new Stack<IPoolObject>();
        }
        public IPoolObject GetItem()
        {
            IPoolObject result;
            if (_poolStack.Count == 0)
            {
                result = GameObject.Instantiate(_poolObject.Self).GetComponent<IPoolObject>();
            }
            else
            {
                result = _poolStack.Pop();
            }
            result.Activate().Pool = this;
            return result;
        }

        public void ReturnToPoll(IPoolObject item) => _poolStack.Push(item);
    }
}
