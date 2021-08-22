using Asteroids;
using UnityEngine;
using Asteroids.Data;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        #region Fields

        

        private Controllers _controllers;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _controllers = new Controllers();
            new GameInitialize(_controllers);
            _controllers.Initialize();
            _controllers.AddGameStateHandlers();
            Debug.Log(EnemyType.Asteroid);
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

        #endregion

    }
}

