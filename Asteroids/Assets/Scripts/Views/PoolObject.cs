using System;
using Asteroids.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Views
{
    internal abstract class PoolObject : BaseRigidbodyMovingObject, IPoolObject
    {
        [SerializeField] private int _lifeTime;
        private IPoolObject _poolObject;
        private IPool _pool;

        public IPool Pool { set => _pool = value; }
        public int LifeTime => _lifeTime;
        public GameObject GameObj => gameObject;


        public virtual IPoolObject Activate()
        {
            gameObject.SetActive(true);
            Invoke(nameof(Deactivate), LifeTime);
            return this;
        }

        protected virtual void Deactivate()
        {
            gameObject.SetActive(false);
            _pool?.ReturnToPool(this);
            CancelInvoke(nameof(Deactivate));
        }

    }
}
