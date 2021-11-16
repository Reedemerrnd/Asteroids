using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Views
{
    public abstract class BaseUI : MonoBehaviour, IUICommand
    {
        public abstract void Cancel();
        public abstract void Execute();
    }
}
