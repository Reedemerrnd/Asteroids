namespace PlayerInput
{
    public class InputInitialize
    {
        #region Fields

        private IInput _input;

        #endregion


        #region ClassLifeCycles

        public InputInitialize(IInput input) => _input = input;

        #endregion


        #region MEthods

        public IInput GetInput() => _input;

        #endregion
    }
}

