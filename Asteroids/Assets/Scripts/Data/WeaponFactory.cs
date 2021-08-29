using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Models;
using Asteroids.Views;

namespace Asteroids.Data
{
    internal class WeaponFactory : AbstractFactory<IWeaponModel, IPool>
    {

        private IWeaponData _weapon;

        public WeaponFactory(IDataLoader dataLoader) : base(dataLoader)
        {

        }
        public void SetWeapon(WeaponType weaponType)
        {
            _weapon = _dataLoader.LoadWeapon(weaponType);
        }


        public override IWeaponModel GetModel()
        {
            return new PrimaryWeapon(_weapon.FireRate, _weapon.FirePower, _weapon.Damage);
        }

        public override IPool GetView()
        {
            var bulletprefab = new GameObject(_weapon.Bullet.Name).SetSprite(_weapon.Bullet.Image)
                                                                  .AddRigidBody2D(1f,0f)
                                                                  .SetCollider<CircleCollider2D>(true)
                                                                  .SetScale(_weapon.Bullet.Scale)
                                                                  .GetOrAddComponent<Bullet>()
                                                                  ;
            bulletprefab.gameObject.SetActive(false);
            bulletprefab.Inject(new OneAxisMove());
            return new Pool(bulletprefab);
        }
    }
}
