using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Data;
using UnityEngine;

namespace Asteroids.Views
{
    internal abstract class BaseAmunition : PoolObject
    {
        protected abstract void Interaction(Collider2D other);

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Interaction(collision);
        }
    }
}

