using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Views
{
    public interface ITakeEnemyDamage : ITakeDamage
    {
        public event Action<int> OnDamageTaken;
    }

}
