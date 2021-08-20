using System.Collections;
using System.Collections.Generic;
using View;
using UnityEngine;

namespace Game
{
    //extract loading resources
    public class PrimaryWeapon : IWeaponModel
    {
        private GameObject _bulletPrefab;
        private int _damage = 3;
        private float _fireRate = 2f;
        private const string PREFABPATH = @"Weapons/bullet";

        public int Damage => _damage;

        public float FireRate => _fireRate;

        public GameObject BulletPrefab => _bulletPrefab;

        public PrimaryWeapon()
        {
            //replace w/ pool/factory
            _bulletPrefab = Resources.Load<Bullet>(PREFABPATH).gameObject;
        }
    }
}
