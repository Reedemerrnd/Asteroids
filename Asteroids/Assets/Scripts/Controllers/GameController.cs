using Game;
using ScriptableObjectData;
using UnityEngine;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Data data;

        private Controllers _controllers;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _controllers = new Controllers();
            new GameInitialize(_controllers, data);
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

        #endregion

    }
}

