namespace Asteroids.Test
{
    internal abstract class WeaponModification : IWeapon
    {
        protected readonly Weapon _weapon;

        public WeaponModification(Weapon weapon)
        {
            _weapon = weapon;
        }

        public virtual void Fire()
        {
            _weapon.Fire();
        }
    }
}
