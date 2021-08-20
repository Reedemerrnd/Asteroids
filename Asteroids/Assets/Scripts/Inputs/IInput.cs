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
        public float Rotation { get; }
        public float Thrust { get; }
    }
}
