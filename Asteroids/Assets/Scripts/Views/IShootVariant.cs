using Asteroids.Data;
using UnityEngine;

namespace Asteroids.Views
{
    public interface IShootVariant
    {
        public void ShootFrom(Transform[] muzzles, float firePower);
        public void SetAmmo(IPool ammoPool);
    }
}
