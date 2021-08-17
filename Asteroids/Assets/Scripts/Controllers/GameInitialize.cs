using Controller;
using Inputs;
using System.Linq;
using Model;
using View;
using UnityEngine;

namespace Game
{
    public class GameInitialize
    {
        public GameInitialize(Controllers controllers)
        {
            var input = new PCInput();
            var playerView = GameObject.FindObjectOfType<PlayerView>();
            var weaponModel = new PrimaryWeapon();
            var playerModel = new ShipModel(100, 10f, 0.3f);

            controllers.Add(new PlayerMovementController(playerView, input, playerModel))
                       .Add(new WeaponController(playerView, weaponModel, input));

        }
    }
}

