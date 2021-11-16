using Asteroids.Core;
using Asteroids.Models;
using Asteroids.Views;
using Inputs;

namespace Controller
{
    internal class AbilityController : IController, IAwakeInitialize, IDisable
    {
        private readonly IShipModel _shipModel;
        private readonly IShip _view;
        private readonly IInput _input;


        public AbilityController(IShipModel shipModel, IShip view, IInput input)
        {
            _shipModel = shipModel;
            _view = view;
            _input = input;
        }

        public void AwakeInit()
        {
            InitPassivses();
            _input.OnAbilityOne += AbilityOneUse;
        }

        private void InitPassivses()
        {
            var passives = _shipModel.GetAbility(AbilityType.Passive);
            if (passives != null)
            {
                foreach (var ability in passives)
                {
                    switch (ability.Name)
                    {
                        case AbilityName.SpeedUp:
                            _shipModel.AddSpeed(ability.Value);
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void AbilityOneUse()
        {
            var warp = _shipModel.GetAbility(AbilityName.Warp);
            if (warp != null)
            {
                _view.Teleport(ScreenBounds.GetRandomPointInBounds());
            }
        }

        public void Disable()
        {
            _input.OnAbilityOne += AbilityOneUse;
        }
    }
}
