using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputs
{
    interface IInput
    {
        public event Action OnFire;
        public Vector2 MousePosition { get; }
        public Vector2 Axes { get; }
    }
}
