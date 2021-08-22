using System;
using Asteroids.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Views
{
    public abstract class InteractiveObject : BaseRigidbodyMovingView, IPoolObject, IInteractable, IDestroyable
    {
        public event Action<GameObject, GameObject> OnInteraction;
        [SerializeField] private int _lifeTime;

        public int Damage { get; set; }
        public IPool Pool { set => _pool = value; }
        public int LifeTime => _lifeTime;
        public GameObject Self => gameObject;

        private IPool _pool;


        private void OnTriggerEnter(Collider other)
        {
            OnInteraction?.Invoke(gameObject, other.gameObject);
        }

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
