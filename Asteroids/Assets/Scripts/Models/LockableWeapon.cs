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



        public float FirePower => _weaponModel.FirePower;

        public int Damage => _weaponModel.Damage;

        public bool CanShoot()
        {
            if (!_locked)
            {
                return _weaponModel.CanShoot();
            }
            return false;
        }

        public void SwitchLock()
        {
            _locked = !_locked;
        }
    }
}
