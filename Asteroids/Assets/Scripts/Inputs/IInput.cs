namespace PlayerInput
{
    public interface IInput : IGetAxes, IGetSaveKey
    {
        public void GetInput();
    }
}

