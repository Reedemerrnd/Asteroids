using System.Collections.Generic;

namespace Controller
{
    public class Controllers
    {
        #region Fields

        private List<IAwakeInitialize> _onAwakes;
        private List<IStartInitialize> _onStarts;
        private List<IExecute> _onUpdates;
        private List<ILateExecute> _onLateUpdates;
        private List<IFixedExecute> _onFixedUpdates;
        private List<IDisable> _onDisables;
        private List<IChangeGameState> _gameStateChangers;
        private List<IGameStateHandler> _gameStateHAndlers;


        #endregion


        #region ClassLifeCycles

        public Controllers()
        {
            _onAwakes = new List<IAwakeInitialize>();
            _onStarts = new List<IStartInitialize>();
            _onFixedUpdates = new List<IFixedExecute>();
            _onLateUpdates = new List<ILateExecute>();
            _onUpdates = new List<IExecute>();
            _onDisables = new List<IDisable>();
            _gameStateChangers = new List<IChangeGameState>();
            _gameStateHAndlers = new List<IGameStateHandler>();
        }

        #endregion


        #region Methods

        public Controllers Add(IController controller)
        {
            if (controller is IAwakeInitialize onAwake)
            {
                _onAwakes.Add(onAwake);
            }
            if (controller is IExecute onUpdate)
            {
                _onUpdates.Add(onUpdate);
            }
            if (controller is IFixedExecute onFixedUpdate)
            {
                _onFixedUpdates.Add(onFixedUpdate);
            }
            if (controller is ILateExecute onLateUpdate)
            {
                _onLateUpdates.Add(onLateUpdate);
            }
            if (controller is IDisable onDisable)
            {
                _onDisables.Add(onDisable);
            }
            if (controller is IChangeGameState initializer)
            {
                _gameStateChangers.Add(initializer);
            }
            if (controller is IGameStateHandler stateHandlers)
            {
                _gameStateHAndlers.Add(stateHandlers);
            }
            if (controller is IStartInitialize startInitialize)
            {
                _onStarts.Add(startInitialize);
            }
            return this;
        }

        public void AwakeInitialize()
        {
            foreach (var controller in _onAwakes)
            {
                controller.AwakeInit();
            }
        }

        public void StartInitialize()
        {
            foreach (var controller in _onStarts)
            {
                controller.StartInit();
            }
        }

        public void Execute()
        {
            foreach (var controller in _onUpdates)
            {
                controller.Execute();
            }
        }

        public void FixedExecute()
        {
            foreach (var controller in _onFixedUpdates)
            {
                controller.FixedExecute();
            }
        }

        public void LateExecute()
        {
            foreach (var controller in _onLateUpdates)
            {
                controller.LateExecute();
            }
        }

        public void Disable()
        {
            foreach (var controller in _onDisables)
            {
                controller.Disable();
            }
        }

        public void AddGameStateHandlers()
        {
            foreach (var controller in _gameStateChangers)
            {
                foreach (var stateHandlers in _gameStateHAndlers)
                {
                    controller.OnGameStateChanged += stateHandlers.UpdateState;
                }
            }
        }

        public void RemoveGameStateHandlers()
        {
            foreach (var controller in _gameStateChangers)
            {
                foreach (var stateHandlers in _gameStateHAndlers)
                {
                    controller.OnGameStateChanged -= stateHandlers.UpdateState;
                }
            }
        }

        #endregion
    }
}

