using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data
{
    [CreateAssetMenu(menuName = @"Data/Ammo")]
    public class BulletData : ScriptableObject
    {
        public string Name;
        public Vector3 Scale;
        public Sprite Image;
    }
}
