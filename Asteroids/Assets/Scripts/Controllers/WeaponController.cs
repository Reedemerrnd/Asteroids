using Asteroids.Models;
using Asteroids.Views;
using Inputs;


namespace Controller
{
    class WeaponController : IController, IInitialize, IExecute, IDisable
    {
        private IShip _view;
        private IWeaponModel _weapon;
        private IInput _input;

        public WeaponController(IShip view, IWeaponModel weapon, IInput input)
        {
            _view = view;
            _weapon = weapon;
            _input = input;
        }


        public void Init()
        {
            _input.OnLockPressed += LockWeapon;
        }

        public void Execute()
        {
            if (_input.FireHold)
            {
                _weapon.Shoot(_view.Barrels);
            }
        }

        private void LockWeapon()
        {
            if (_weapon is ILockable lockable)
            {
                lockable.SwitchLock();
            }

        }

        public void Disable()
        {
            _input.OnLockPressed -= LockWeapon;
        }
    }
}
