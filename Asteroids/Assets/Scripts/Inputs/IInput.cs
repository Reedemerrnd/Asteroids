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
        public bool FireHold { get; }
        public float Rotation { get; }
        public (float, float) Thrust { get; }
        public event Action OnAbilityOne;
        public event Action OnAbilityTwo;
        public event Action OnLockPressed;
    }
}
