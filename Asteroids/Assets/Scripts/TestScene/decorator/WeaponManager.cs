using UnityEngine;
using UnityEngine.InputSystem;

namespace Asteroids.Test
{
    public class WeaponManager : MonoBehaviour
    {
        public Transform Barrel;
        public Ammo Bullet;

        [Header("Scope")]
        public Transform ScopeMount;
        public GameObject ScopePrefab;

        [Header("Muffler")]
        public MufflerMarker Muffler;



        private IWeapon _weapon;
        private Mouse _mouse;

        private Muffler _muffler;
        private bool _isSilenced = false;
        private Scope _scope;
        private bool _isScoped = false;
        private SilencedWeaponWithPointer _silencedWeapon;

        // Start is called before the first frame update
        void Start()
        {
            var weapon =  new Weapon(700, Bullet, Barrel);
            _silencedWeapon = new SilencedWeaponWithPointer(weapon, ScopeMount);
            _muffler = new Muffler(Muffler, 0.5f);
            _scope = new Scope(ScopePrefab, 1.3f);

            _mouse = Mouse.current;
            _weapon = _silencedWeapon;
        }

        // Update is called once per frame
        void Update()
        {
            if (_mouse.leftButton.wasPressedThisFrame)
            {
                _weapon.Fire();
            }
            if (_mouse.rightButton.wasPressedThisFrame)
            {
                SwitchSilencer();
            }
            if (_mouse.middleButton.wasPressedThisFrame)
            {
                SwitchScope();
            }
        }

        private void SwitchScope()
        {
            if (!_isScoped)
            {
                _silencedWeapon.AddMod(_scope);
            }
            else
            {
                _silencedWeapon.Remove(_scope);
            }
            _isScoped = !_isScoped;
        }

        private void SwitchSilencer()
        {
            if (!_isSilenced)
            {
                _silencedWeapon.AddMod(_muffler);
            }
            else
            {
                _silencedWeapon.Remove(_muffler);
            }
            _isSilenced = !_isSilenced;
        }
    }


}
