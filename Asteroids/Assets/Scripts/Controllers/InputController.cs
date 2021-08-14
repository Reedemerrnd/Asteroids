using PlayerInput;

namespace Controller
{
    public class InputController : IExecute, IController
    {
        #region Fields

        private IInput _input;

        #endregion


        #region ClassLifeCycles

        public InputController(IInput input)
        {
            _input = input;
        }

        #endregion


        #region IOnUpdate

        public void Execute()
        {
            _input.GetInput();
        }

        #endregion
    }
}

