using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Data;
using UnityEngine;

namespace Asteroids.Views
{
    public abstract class BaseAmunition : BaseFlyingObjectView, IPoolObject, IDoDamage
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


    }
}

