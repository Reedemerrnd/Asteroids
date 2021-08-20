using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public interface IWeaponModel
    {
        public int Damage { get; }
        public float FireRate { get; }
        public GameObject BulletPrefab { get; }
    }
}
