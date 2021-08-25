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

        public IPool Pool { set => _pool = value; }
        public int LifeTime => _lifeTime;
        public GameObject Self => gameObject;

        private IPool _pool;

        public virtual IPoolObject Activate()
        {
            gameObject.SetActive(true);
            Invoke(nameof(Deactivate), LifeTime);
            return this;
        }

        protected virtual void Deactivate()
        {
            gameObject.SetActive(false);
            _pool?.ReturnToPoll(this);
            CancelInvoke(nameof(Deactivate));
        }

    }
}
