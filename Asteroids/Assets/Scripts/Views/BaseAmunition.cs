using UnityEngine;
using Asteroids.Models;

namespace Asteroids.Views
{
    internal abstract class BaseAmunition : PoolObject, IProjectile
    {
        private IMoveVariant _move;
        private Rigidbody2D _rigidbody;

        protected int _damage;

        public IMoveVariant Movement => _move;

        public void SetDamage(int damage) => _damage = damage;



        private void OnTriggerEnter2D(Collider2D collision)
        {
            Interaction(collision);
        }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        protected abstract void Interaction(Collider2D other);


        public void Inject(IMoveVariant dependency)
        {
            _move = dependency;
        }

        protected override void Deactivate()
        {
            _move.Stop(_rigidbody);
            base.Deactivate();
        }

        public override GameObject Clone()
        {
            var obj = Instantiate(gameObject);
            var ammo = obj.GetComponent<BaseAmunition>();
            ammo._move = _move;
            ammo._damage = _damage;

            return obj;
        }

        public void Launch(Vector2 direction, float speed)
        {
            _move.Move(_rigidbody, direction, speed);
        }
    }
}

