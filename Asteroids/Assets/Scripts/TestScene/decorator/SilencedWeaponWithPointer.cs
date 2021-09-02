using UnityEngine;

namespace Asteroids.Test
{
    internal class SilencedWeaponWithPointer : WeaponModification, IModifiable<Muffler>, IModifiable<Scope>
    {
        private readonly Transform _scopeMount;

        private Transform _baseMuzzle;

        private GameObject _muffler;
        private GameObject _scope;

        public SilencedWeaponWithPointer(Weapon weapon, Transform scopeMount) : base(weapon)
        {
            _scopeMount = scopeMount;
        }
        public void AddMod(Muffler mod)
        {
            _muffler = Object.Instantiate(mod.Prefab, _weapon.BarrelPosition.position, Quaternion.identity);
            _baseMuzzle = _weapon.BarrelPosition;
            _weapon.BarrelPosition = _muffler.GetComponent<MufflerMarker>().Barrel;
            _weapon.Firepower *= mod.FirePowerModifier;
        }

        public void AddMod(Scope mod)
        {
            _scope = Object.Instantiate(mod.Prefab, _scopeMount.position, Quaternion.identity);
            _weapon.Firepower *= mod.FirePowerModifier;
        }

        public void Remove(Muffler mod)
        {
            _weapon.BarrelPosition = _baseMuzzle;
            _weapon.Firepower /= mod.FirePowerModifier;
            Object.Destroy(_muffler);
        }

        public void Remove(Scope mod)
        {
            _weapon.Firepower /= mod.FirePowerModifier;
            Object.Destroy(_scope);
        }
    }
}
