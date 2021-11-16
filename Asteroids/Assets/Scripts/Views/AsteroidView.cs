using System;
using UnityEngine;
using Asteroids.Data;
using Asteroids.Models;
using Asteroids.Core;

namespace Asteroids.Views
{
    internal class AsteroidView : PoolObject, IEnemy
    {
        [SerializeField] private EnemyType _type;
        private int _health;
        private int _damage;
        private IMoveVariant _move;
        private Rigidbody2D _rigidbody;

        public event Action<EnemyType> OnEnemyDeath = delegate(EnemyType enemyType) {};

        public EnemyType Type => _type; 
        public int Health
        {
            get => _health;
            set
            {
                if (value <= 0)
                {
                    OnEnemyDeath?.Invoke(Type);
                    Deactivate();
                }
                else
                {
                    _health = value;
                }
            }
        }


        private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();
        private void OnTriggerEnter2D(Collider2D collision) => Interaction(collision);


        public void SetDamage(int damage) => _damage = damage;

        private void Interaction(Collider2D other)
        {
            if (other.gameObject.TryGetComponent<ITakeEnemyDamage>(out var player))
            {
                player.TakeDamage(_damage);
                Deactivate();
            }
        }
        public void TakeDamage(int damage) => Health -= damage;

        public void Launch(Vector2 direction, float speed) => _move.Move(_rigidbody, direction, speed);

        public void Inject(IMoveVariant dependency) => _move = dependency;


        protected override void Deactivate()
        {

            _move.Stop(_rigidbody);
            base.Deactivate();
        }
        public override GameObject Clone()
        {
            OnEnemyDeath = delegate { };
            var obj = Instantiate(gameObject);
            obj.GetComponent<AsteroidView>()._move = _move;
            return obj;
        }

        public void SubscribeOnDeath(Action<EnemyType> subscriber)
        {
            OnEnemyDeath += subscriber;
        }
        public void Activate(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

