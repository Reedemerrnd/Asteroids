using Asteroids.Data;
using System;
using UnityEngine;

namespace Asteroids.Views
{
    public class BaseShootVariant : IShootVariant
    {
        private IPool _ammoPool;
        public void SetAmmo(IPool ammoPool)
        {
            _ammoPool = ammoPool;
        }
        public void ShootFrom(Transform[] muzzles, float firePower)
        {
            foreach (var muzzle in muzzles)
            {
                var bulletPrefab = _ammoPool.GetItemAt(muzzle.transform.position, muzzle.rotation).GameObj;
                var bullet = bulletPrefab.GetComponent<Bullet>();
                bullet.Move(Vector2.up, firePower);
            }
        }
    }
}
