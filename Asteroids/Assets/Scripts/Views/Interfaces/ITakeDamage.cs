using System;
using UnityEngine;

namespace Asteroids.Views
{
    public interface ITakeDamage
    {
        public event Action<GameObject, int> OnDamageTaken;
    }

}
