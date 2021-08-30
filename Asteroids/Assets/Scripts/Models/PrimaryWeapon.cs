using System.Collections;
using System.Collections.Generic;
using Asteroids.Data;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Models
{
    public class PrimaryWeapon : IWeaponModel
    {
        private float _firePower;
        private int _damage;
        private float _time;
        private readonly float _delay;

        public float FirePower => _firePower;
        public int Damage => _damage;
        public PrimaryWeapon(float fireRate, float firePower, int damage)
        {
            _firePower = firePower;
            _damage = damage;
            _delay = 1f / fireRate;
            _time = Time.time;
        }

        public bool CanShoot()
        {
            if(_time + _delay <= Time.time)
            {
                _time = Time.time;
                return true;
            }
            return false;
        }
    }
}
