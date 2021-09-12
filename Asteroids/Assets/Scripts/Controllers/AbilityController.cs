using System;
using Asteroids.Core;
using Asteroids.Models;
using Asteroids.Views;
using Inputs;
using UnityEngine;

namespace Controller
{
    internal class AbilityController : IController, IInitialize, IDisable
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

        public void Init()
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
                            Debug.Log("speedUp");
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
            if(warp != null)
            {
                _view.MoveComponent.transform.position = ScreenBounds.GetRandomPointInBounds();
            }
        }

        public void Disable()
        {
            _input.OnAbilityOne += AbilityOneUse;
        }
    }
}
