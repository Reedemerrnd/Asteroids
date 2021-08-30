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
        public bool Fire { get; }
        public float Rotation { get; }
        public Vector2 Thrust { get; }
    }
}
