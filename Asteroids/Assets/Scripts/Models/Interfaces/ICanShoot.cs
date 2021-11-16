using Asteroids.Views;

namespace Asteroids.Models
{
    internal interface ICanShoot : IInjectable<IWeaponModel>
    {
        public IWeaponModel Weapon { get; }
    }
}
