
using System.Collections.Generic;
using Asteroids.Views;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    public class Pool : IPool
    {
        IPoolObject _poolObject;

        private Stack<GameObject> _poolStack;
        public Pool(IPoolObject poolObject)
        {
            _poolObject = poolObject;
            _poolStack = new Stack<GameObject>();
        }
        public IPoolObject GetItem()
        {
            return GetItemAt(Vector3.zero, Quaternion.identity);
        }
        public IPoolObject GetItemAt(Vector3 position, Quaternion rotation)
        {
            var obj = _poolStack.Count == 0 ? Object.Instantiate(_poolObject.GameObj) : _poolStack.Pop();
            obj.transform.position = position;
            obj.transform.rotation = rotation;
            var result = obj.GetComponent<IPoolObject>().Activate(3f); //magick number to remove
            result.Pool = this;
            return result;
        }

        public void ReturnToPool(IPoolObject item) => _poolStack.Push(item.GameObj);

    }
}