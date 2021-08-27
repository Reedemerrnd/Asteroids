using System.Collections;
using System.Collections.Generic;
using Asteroids.Data;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Models
{
    public class PrimaryWeapon : IWeaponModel
    {
        private float _fireRate;
        private float _firePower;
        private int _damage;

        public float FireRate => _fireRate;
        public float FirePower => _firePower;
        public int Damage => _damage;
        public PrimaryWeapon(float fireRate, float firePower, int damage)
        {
            _fireRate = fireRate;
            _firePower = firePower;
            _damage = damage;
        }

    }
}
