using System;
using UnityEngine;

namespace Asteroids.Views
{
    public interface IInteractable
    {
        public event Action<GameObject, GameObject> OnInteraction;
    }

}
