using UnityEngine;

namespace Asteroids.Models
{
    public interface IEnemySpawnModel
    {
        public Vector3 GetSpawnPoint();
        public float MinDelay { get; }
        public float MaxDelay { get; }
        public float Offset { get; }
    }
}
