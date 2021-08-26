using System;
using Asteroids.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public interface IEnemyModel : IMoveModel, IDoDamage
    {
        public EnemyType enemyType { get; }
        public int Health { get; }
    }
}
