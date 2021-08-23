using System;
using Asteroids.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Views
{
    public abstract class InteractiveObject : BaseRigidbodyMovingView, IPoolObject, IDestroyable
    {
        [SerializeField] private int _lifeTime;

        public int Damage { get; set; }
        public IPool Pool { set => _pool = value; }
        public int LifeTime => _lifeTime;
        public GameObject Self => gameObject;

        private IPool _pool;


        private void OnTriggerEnter2D(Collider2D other)
        {
            Interaction(other);
        }
        protected abstract void Interaction(Collider2D other);


        public IPoolObject Activate()
        {
            gameObject.SetActive(true);
            Invoke(nameof(Deactivate), LifeTime);
            return this;
        }

        protected void Deactivate()
        {
            gameObject.SetActive(false);
            _pool?.ReturnToPoll(this);
            CancelInvoke(nameof(Deactivate));
        }

        
        public void Destroy() => Deactivate();
    }
}
