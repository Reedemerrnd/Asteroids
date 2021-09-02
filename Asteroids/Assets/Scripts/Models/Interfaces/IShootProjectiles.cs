using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    internal interface IShootProjectiles
    {
        public float FireRate { get; }
        public float FirePower { get; }
    }
}
