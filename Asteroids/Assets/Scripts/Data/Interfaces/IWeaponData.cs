using System;
using UnityEngine;

namespace Asteroids.Data
{
    public interface IWeaponData
    {
        public BulletData Bullet { get;}
        public WeaponType Type { get; }
        public GameObject AmmoPrefab { get; }
        public float FireRate { get; }
        public float FirePower { get; }
        public int Damage { get; }
    }
}
