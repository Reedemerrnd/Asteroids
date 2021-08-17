using System;
using View;
using Game;
using Inputs;
using UnityEngine;
using System.Collections.Generic;


namespace Controller
{
    class WeaponController : IController, IInitialize, IDisable
    {
        private IShoot _view;
        private IWeaponModel _weapon;
        private IInput _input;

        public WeaponController(IShoot view, IWeaponModel weapon, IInput input)
        {
            _view = view;
            _weapon = weapon;
            _input = input;
        }

        private void Shoot()
        {
            foreach (var muzzle in _view.MuzzlesTransform)
            {
                var bullet = GameObject.Instantiate(_weapon.BulletPrefab, muzzle.position, muzzle.rotation);
                bullet.GetComponent<IBullet>().Fire();
                GameObject.Destroy(bullet, 4f);
            }
        }

        public void Disable()
        {
            _input.OnFire -= Shoot;
        }

        public void Init()
        {
            _input.OnFire += Shoot;
        }
    }
}
