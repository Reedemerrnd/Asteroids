using UnityEngine;

namespace Asteroids.Models
{
    public class LockableWeapon : IWeaponModel, ILockable
    {
        private readonly IWeaponModel _weaponModel;
        private bool _locked = false;

        public LockableWeapon(IWeaponModel weaponModel)
        {
            _weaponModel = weaponModel;
        }

        public void Shoot(Transform[] muzzles)
        {
            if (!_locked)
            {
                _weaponModel.Shoot(muzzles);
            }
        }

        public void SwitchLock()
        {
            _locked = !_locked;
        }
    }
}
