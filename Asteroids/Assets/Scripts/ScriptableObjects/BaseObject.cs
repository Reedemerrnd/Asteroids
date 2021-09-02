using System;
using UnityEngine;

namespace Asteroids.Data
{
    public abstract class BaseObject : ScriptableObject
    {
        [SerializeField] protected GameObject _prefab;
    }
}
