using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = "Game Resources/Weapon")]
    public class WeaponData : ScriptableObject
    {
        public BulletData Bullet;
        public float FirePower;
        public WeaponType Type;
        public float FireRate;
    }
}
