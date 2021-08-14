using System;
using UnityEngine;

namespace View
{
    public interface IColliderInteraction
    {
        public event Action<Collider2D> OnColliderInteraction;
    }
}
