using Asteroids;
using UnityEngine;
using Asteroids.Data;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        private Controllers _controllers;

        private void Start()
        {
            _controllers = new Controllers();
            //Facade ?
            new GameInitialize(_controllers, PlayerShip.Base);
            _controllers.Initialize();
            _controllers.AddGameStateHandlers();
        }

        private void Update()
        {
            _controllers.Execute();
        }

        private void FixedUpdate()
        {
            _controllers.FixedExecute();
        }

        private void LateUpdate()
        {
            _controllers.LateExecute();
        }

        private void OnDestroy()
        {
            _controllers.Disable();
            _controllers.RemoveGameStateHandlers();
        }

    }
}

