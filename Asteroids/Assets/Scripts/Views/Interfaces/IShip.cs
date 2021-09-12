using UnityEngine;

namespace Asteroids.Views
{
    internal interface IShip : IHaveWeapons, ITakeEnemyDamage, IMovable<Rigidbody2D>
    {

    }
}
