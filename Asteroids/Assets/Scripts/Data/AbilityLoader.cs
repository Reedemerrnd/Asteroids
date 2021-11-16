using Asteroids.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    class AbilityLoader
    {
        public Ability GetAbility(string name)
        {
            return Resources.Load<Ability>($"Abilities/{name}");
        }
    }
}
