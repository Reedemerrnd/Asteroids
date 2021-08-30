using Asteroids.Data;
using UnityEngine;

namespace Asteroids.Views
{
    public interface IShoot
    {
        public void Shoot(float firePower);
        public void SetAmmo(IPool ammoPool);
    }
}
