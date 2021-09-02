using UnityEngine;

namespace Asteroids.Test
{
    internal sealed class Weapon : IWeapon
    {
        private float _firepower;
        private IAmmo _bullet;
        private Transform _barrelPosition;

        public Weapon(float firepower, IAmmo bullet, Transform barrelPosition)
        {
            _firepower = firepower;
            _bullet = bullet;
            _barrelPosition = barrelPosition;
        }

        public Transform BarrelPosition { get => _barrelPosition; set => _barrelPosition = value; }
        public float Firepower { get => _firepower; set => _firepower = value; }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.Rigidbody, _barrelPosition.position,_barrelPosition.rotation);
            bullet.AddForce(Vector2.right * _firepower);
            Object.Destroy(bullet, 2f);
        }
    }
}
