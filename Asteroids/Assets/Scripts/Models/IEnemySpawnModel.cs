using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Models
{
    public interface IEnemySpawnModel
    {
        public Vector3 GetSpawnPoint();
        public float MinDelay {get;}
        public float MaxDelay { get; }
        public float Offset { get; }
    }
}
