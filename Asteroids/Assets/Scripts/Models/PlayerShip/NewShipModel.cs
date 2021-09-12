using System.Collections;
using System.Collections.Generic;

namespace Asteroids.Models
{
    public class NewShipModel : IShipModel
    {
        private float _speed;
        private float _rotationSpeed;
        private List<Ability> _abilities;

        private IMoveAndRotateVariant _move;
        private IWeaponModel _weapon;
        private IHealthModel _health;


        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;
        public IMoveAndRotateVariant Movement => _move;
        public IWeaponModel Weapon => _weapon;
        public IHealthModel Health => _health;

        public Ability this[int index] => _abilities[index];

        public NewShipModel(float speed, float rotationSpeed)
        {
            _speed = speed;
            _rotationSpeed = rotationSpeed;
            _abilities = new List<Ability>(10);
        }


        public void Inject(IMoveAndRotateVariant dependency) => _move = dependency;

        public void Inject(IWeaponModel dependency) => _weapon = dependency;

        public void Inject(IHealthModel dependency) => _health = dependency;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _abilities.Count; i++)
            {
                yield return _abilities[i];
            }
        }
        public IEnumerable<Ability> GetAbility(AbilityType index)
        {
            foreach (var ability in _abilities)
            {
                if(ability.Type == index)
                {
                    yield return ability;
                }
            }
        }

        public void AddAbility(Ability ability)
        {
            if (!_abilities.Contains(ability))
            {
                _abilities.Add(ability);
            }
        }

        public IEnumerable<Ability> GetAbility(AbilityName index)
        {
            foreach (var ability in _abilities)
            {
                if (ability.Name == index)
                {
                    yield return ability;
                }
            }
        }
        public void AddSpeed(float speed) => _speed+=speed;
    }
}
