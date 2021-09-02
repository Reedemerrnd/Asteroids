using Asteroids.Data;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Models
{
    public class PrimaryWeapon : IWeaponModel
    {
        private float _lastShotTime;
        private float _firePower;
        private readonly float _delay;
        private IPool _ammoPool;

        public PrimaryWeapon(float fireRate, float firePower, IPool ammo)
        {
            _firePower = firePower;
            _ammoPool = ammo;
            _delay = 1f / fireRate;
            _lastShotTime = Time.time;
        }

        public void Shoot(Transform[] muzzles)
        {
            if (CheckFireDelay())
            {
                foreach (var muzzle in muzzles)
                {
                    var bullet = (IProjectile)_ammoPool.GetItemAt(muzzle.position, muzzle.rotation);
                    bullet.Launch(Vector2.up, _firePower);
                }
                _lastShotTime = Time.time;
            }
        }

        private bool CheckFireDelay() => _lastShotTime + _delay <= Time.time;
    }
}
