using System;
using Asteroids.Views;
using Asteroids;
using Inputs;
using Asteroids.Models;
using Asteroids.Data;
using UnityEngine;
using System.Collections.Generic;


namespace Controller
{
    class WeaponController : IController, IInitialize, IDisable
    {
        private IShoot _view;
        private IWeaponModel _weapon;
        private IInput _input;
        private IPool _ammoPool;

        public WeaponController(IShoot view, IWeaponModel weapon, IInput input, IPool ammoPool)
        {
            _view = view;
            _weapon = weapon;
            _input = input;
            _ammoPool = ammoPool;
        }

        // Inplement firerate
        private void Shoot()
        {
            foreach (var muzzle in _view.MuzzlesTransform)
            {
                var bullet = _ammoPool.GetItem().Self;
                bullet.transform.position = muzzle.transform.position;
                bullet.transform.rotation = muzzle.rotation;
                bullet.GetComponent<Bullet>().Move(1f, _weapon.FirePower);
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
