using System;

namespace PlayerInput
{
    public interface IGetSaveKey
    {
        public event Action OnSaveKeyPressed;
        public event Action OnLoadKeyPressed;
    }

}
