namespace Asteroids.Models
{
    public class LockableWeapon : IWeaponModel
    {
        private readonly IWeaponModel _weaponModel;

        public LockableWeapon(IWeaponModel weaponModel)
        {
            _weaponModel = weaponModel;
        }



        public float FirePower => _weaponModel.FirePower;

        public int Damage => _weaponModel.Damage;

        public bool CanShoot()
        {
            throw new System.NotImplementedException();
        }
    }
}
