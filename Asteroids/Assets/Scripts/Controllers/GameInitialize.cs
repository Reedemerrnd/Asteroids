using Controller;
using ScriptableObjectData;
using Inputs;
using System.Linq;
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

            controllers
                 .Add(new PlayerMovementController(playerView, input));

        }
    }
}

