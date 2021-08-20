using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ShipModel : IPlayerModel
    {

        private int _health;
        private int _maxHealth;



        public event Action OnDeath;
        public int Health
        {
            get => _health;
            set
            {
                _health += value;
                if(_health <= 0)
                {
                    OnDeath?.Invoke();
                }
                else if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
            }
        }
        public float Speed { get; }
        public float RotationSpeed { get; }
       
        
        public ShipModel(int maxHealth, float speed, float rotationSpeed)
        {
            _maxHealth = maxHealth;
            _health = _maxHealth;
            Speed = speed;
            RotationSpeed = rotationSpeed;
        }
    }
}
