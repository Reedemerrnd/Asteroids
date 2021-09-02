using Asteroids.Views;

namespace Asteroids.Models
{
    public class NewShipModel : IShipModel
    {
        private float _speed;
        private float _rotationSpeed;

        private IMoveAndRotateVariant _move;
        private IWeaponModel _weapon;
        private IHealthModel _health;

        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;

        public NewShipModel(float speed, float rotationSpeed)
        {
            _speed = speed;
            _rotationSpeed = rotationSpeed;
        }

        public IMoveAndRotateVariant Movement => _move;
        public IWeaponModel Weapon => _weapon;

        public IHealthModel Health => _health;

        public void Inject(IMoveAndRotateVariant dependency) => _move = dependency;

        public void Inject(IWeaponModel dependency) => _weapon = dependency;

        public void Inject(IHealthModel dependency) => _health = dependency;
    }
}
