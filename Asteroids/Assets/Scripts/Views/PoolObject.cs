using System;
using Asteroids.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Views
{
    internal abstract class PoolObject : MonoBehaviour, IPoolObjectPrototype
    {
        private float _lifeTime;
        private IPoolObjectPrototype _poolObject;
        private IPool _pool;

        public IPool Pool { set => _pool = value; }
        public GameObject GameObj => gameObject;


        public virtual IPoolObjectPrototype Activate(float lifeTime)
        {
            gameObject.SetActive(true);
            _lifeTime = lifeTime;
            Invoke(nameof(Deactivate), _lifeTime);
            return this;
        }

        protected virtual void Deactivate()
        {
            gameObject.SetActive(false);
            _pool?.ReturnToPool(this);
            CancelInvoke(nameof(Deactivate));
        }
        public abstract GameObject Clone();
    }
}
