using System;
using UnityEngine;

namespace PlayerInput
{
    public class PCInput : IInput
    {
        public event Action<(float, float)> OnAxisChange;
        public event Action OnSaveKeyPressed;
        public event Action OnLoadKeyPressed;

        public void GetInput()
        {
            //var vertical = Input.GetAxis(AxisManager.VERTICAL);
            //var horizontal = Input.GetAxis(AxisManager.HORIZONTAL);

            //OnAxisChange?.Invoke((vertical, horizontal));

            if (Input.GetKeyDown(KeyCode.F5))
            {
                OnSaveKeyPressed?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.F9))
            {
                OnLoadKeyPressed?.Invoke();
            }
        }
    }
}

