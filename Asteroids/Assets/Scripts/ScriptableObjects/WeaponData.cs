using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Weapon")]
    public class WeaponData : ScriptableObject, IWeaponData
    {
        [SerializeField] private float _firePower;
        [SerializeField] private WeaponType _type;
        [SerializeField] private GameObject _ammoPrefab;
        [SerializeField] private float _fireRate;
        [SerializeField] private int _damage;

        public WeaponType Type => _type;
        public GameObject AmmoPrefab => _ammoPrefab;
        public float FireRate => _fireRate;
        public int Damage => _damage;

        public float FirePower => _firePower;
    }
}
