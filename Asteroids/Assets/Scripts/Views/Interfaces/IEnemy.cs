using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Data;

namespace Asteroids.Views
{
    public interface IEnemy : IEnemyHealth, ITakeDamage, IDoDamage
    {
        public EnemyType Type { get;}
    }
}
