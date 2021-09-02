using UnityEngine;

namespace Asteroids.Test
{
    internal class Muffler
    {
        private GameObject _prefab;
        private Transform _muzzle;
        private float _firePowerModifier;

        public GameObject Prefab => _prefab;
        public Transform Muzzle => _muzzle;
        public float FirePowerModifier => _firePowerModifier;

        public Muffler(MufflerMarker Muffler, float firePowerModifier = 1)
        {
            _prefab = Muffler.gameObject;
            _muzzle = Muffler.Barrel;
            _firePowerModifier = firePowerModifier;
        }
    }
}
