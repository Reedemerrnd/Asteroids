using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public interface IHealthModel
    {
        public event Action OnDeath;
        public int Health { get; set; }
    }
}
