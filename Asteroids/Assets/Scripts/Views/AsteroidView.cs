using System;
using UnityEngine;
using Asteroids.Data;

namespace Asteroids.Views
{
    public class AsteroidView : BaseFlyingObjectView, IPoolObject
    {
        [SerializeField] private int _lifeTime;

        public int Damage { get; set; }
        public IPool Pool { set => _pool = value; }
        public int LifeTime => _lifeTime;
        public GameObject Self => gameObject;

        private IPool _pool;


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

        public override void Interaction() => throw new NotImplementedException();//получать урон
    }
}

