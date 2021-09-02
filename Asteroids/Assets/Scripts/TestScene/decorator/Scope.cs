using UnityEngine;

namespace Asteroids.Test
{
    internal class Scope
    {
        private readonly GameObject _prefab;
        private float _firePowerModifier;

        public GameObject Prefab => _prefab;

        public float FirePowerModifier => _firePowerModifier;

        public Scope(GameObject prefab, float firePowerModifier = 1)
        {
            _prefab = prefab;
            _firePowerModifier = firePowerModifier;
        }
    }
}
