using Asteroids.Views;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Data
{
    public class Pool : IPool
    {
        private IPoolObjectPrototype _poolObject;

        private Stack<GameObject> _poolStack;


        public Pool(IPoolObjectPrototype poolObject)
        {
            _poolObject = poolObject;
            _poolStack = new Stack<GameObject>();
        }


        public IPoolObjectPrototype GetItem()
        {
            return GetItemAt(Vector3.zero, Quaternion.identity);
        }

        public IPoolObjectPrototype GetItemAt(Vector3 position, Quaternion rotation)
        {
            var obj = _poolStack.Count == 0 ? _poolObject.Clone() : _poolStack.Pop();
            obj.transform.position = position;
            obj.transform.rotation = rotation;
            var result = obj.GetComponent<IPoolObjectPrototype>().Activate(3f); //magick number to remove
            result.Pool = this;
            return result;
        }

        public void ReturnToPool(IPoolObjectPrototype item) => _poolStack.Push(item.GameObj);

    }
}