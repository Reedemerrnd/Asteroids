using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Data;

namespace Asteroids.Models
{
    public interface IEnemyModelSet
    {
        IEnemyModel this[EnemyType index]
        {
            get;
        }

        public int Count { get; }
        public EnemyType[] Keys { get; }


    }
}
