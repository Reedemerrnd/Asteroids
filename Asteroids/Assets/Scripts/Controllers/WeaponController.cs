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
    class WeaponController : IController, IInitialize, IExecute
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


        public void Init()
        {
            _view.SetAmmo(_ammoPool);
        }

        public void Execute()
        {
            if (_input.Fire && _weapon.CanShoot())
            {
                _view.Shoot(_weapon.FirePower);
            }
            if(_input.Lock && _weapon is ILockable lockable)
            {
                lockable.SwitchLock();
            }
        }
    }
}
