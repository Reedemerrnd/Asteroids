using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asteroids.Data;
using UnityEngine;

namespace Asteroids.Views
{
    public abstract class BaseAmunition : InteractiveObject
    {
        protected override void Interaction(GameObject target)
        {
            base.Interaction(target);
            Destroy();
        }
    }
}

