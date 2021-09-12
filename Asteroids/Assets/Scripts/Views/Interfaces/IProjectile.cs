using Asteroids.Models;
using UnityEngine;

namespace Asteroids.Views
{
    internal interface IProjectile : IDoDamage
    {
        public void Launch(Vector2 direction, float speed);
    }
}

