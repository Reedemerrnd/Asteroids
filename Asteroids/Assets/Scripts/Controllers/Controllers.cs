using System.Collections.Generic;

namespace Controller
{
    public class Controllers
    {
        #region Fields

        private List<IInitialize> _onAwakes;
        private List<IExecute> _onUpdates;
        private List<ILateExecute> _onLateUpdates;
        private List<IFixedExecute> _onFixedUpdates;
        private List<IDisable> _onDisables;
        private List<IChangeGameState> _refreshInitilizers;
        private List<IGameStateHandler> _refreshables;


        #endregion


        #region ClassLifeCycles

        public Controllers()
        {
            _onAwakes = new List<IInitialize>();
            _onFixedUpdates = new List<IFixedExecute>();
            _onLateUpdates = new List<ILateExecute>();
            _onUpdates = new List<IExecute>();
            _onDisables = new List<IDisable>();
            _refreshInitilizers = new List<IChangeGameState>();
            _refreshables = new List<IGameStateHandler>();
        }

        #endregion


        #region Methods

        public Controllers Add(IController controller)
        {
            if (controller is IInitialize onAwake)
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
                _refreshInitilizers.Add(initializer);
            }
            if (controller is IGameStateHandler refreshable)
            {
                _refreshables.Add(refreshable);
            }
            return this;
        }

        public void Initialize()
        {
            foreach (var controller in _onAwakes)
            {
                controller.Init();
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
            foreach (var controller in _refreshInitilizers)
            {
                foreach (var refreshable in _refreshables)
                {
                    controller.OnGameStateChanged += refreshable.UpdateState;
                }
            }
        }

        public void RemoveGameStateHandlers()
        {
            foreach (var controller in _refreshInitilizers)
            {
                foreach (var refreshable in _refreshables)
                {
                    controller.OnGameStateChanged -= refreshable.UpdateState;
                }
            }
        }

        #endregion
    }
}

