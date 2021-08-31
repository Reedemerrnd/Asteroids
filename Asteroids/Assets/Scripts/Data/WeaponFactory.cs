using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;
using Asteroids.Views;

namespace Asteroids.Data
{
    internal class WeaponFactory
    {

        private WeaponData _weapon;
        private readonly IDataLoader _dataLoader;

        public WeaponFactory(IDataLoader dataLoader)
        {
            _dataLoader = dataLoader;
        }

        public void SetWeapon(WeaponType weaponType)
        {
            _weapon = _dataLoader.LoadWeapon(weaponType);
        }


        public IWeaponModel GetModel()
        {
            Bullet bulletprefab = BuildBullet();
            var ammoPool = new Pool(bulletprefab);
            return new PrimaryWeapon(_weapon.FireRate, _weapon.FirePower, ammoPool);
        }

        private Bullet BuildBullet()
        {
            var bulletprefab = new GameObject(_weapon.Bullet.Name)
                .SetSprite(_weapon.Bullet.Image)
                .AddRigidBody2D(1f, 0f)
                .SetCollider<CircleCollider2D>(true)
                .SetScale(_weapon.Bullet.Scale)
                .GetOrAddComponent<Bullet>()
                ;
            bulletprefab.gameObject.SetActive(false);
            bulletprefab.SetDamage(_weapon.Bullet.Damage);
            bulletprefab.Inject(new OneAxisMove());
            return bulletprefab;
        }
    }
}
