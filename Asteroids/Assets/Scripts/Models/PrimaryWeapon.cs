using System.Collections;
using System.Collections.Generic;
using Asteroids.Data;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Models
{
    public class PrimaryWeapon : IWeaponModel
    {
        private int _damage;
        private float _fireRate;
        private readonly float _firePower;

        public int Damage => _damage;

        public float FireRate => _fireRate;
        public float FirePower => _firePower;
        public PrimaryWeapon(IWeaponData data)
        {
            _damage = data.Damage;
            _fireRate = data.FireRate;
            _firePower = data.FirePower;
        }

    }
}
