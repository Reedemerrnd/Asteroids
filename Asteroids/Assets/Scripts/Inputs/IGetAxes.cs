using System;

namespace PlayerInput
{
    public interface IGetAxes
    {
        public event Action<(float, float)> OnAxisChange;
    }
}

