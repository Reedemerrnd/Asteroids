using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Data
{
    public interface ISpawnedGameObjectsList
    {
        public IEnumerable<GameObject> GameObjects { get; }
    }
}
