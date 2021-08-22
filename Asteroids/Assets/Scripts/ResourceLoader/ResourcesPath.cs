using System;
using System.Collections.Generic;

namespace Asteroids.Data
{
    public static class ResourcesPath
    {
        public static readonly Dictionary<PlayerShip, string> PlayerShips = new Dictionary<PlayerShip, string>()
        {
            {
                PlayerShip.Base, $@"Ships/{PlayerShip.Base}"
            }
        };

        public static readonly Dictionary<EnemyType, string> Enemies = new Dictionary<EnemyType, string>()
        {
            {
                EnemyType.Asteroid, $@"Enemies/{EnemyType.Asteroid}"
            },
            {
                EnemyType.SmallShip,$@"Enemies/{EnemyType.SmallShip}"
            },
                        {
                EnemyType.SmallAsteroid,$@"Enemies/{EnemyType.SmallAsteroid}"
            }
        };

        public static readonly Dictionary<WeaponType, string> Weapons = new Dictionary<WeaponType, string>()
        {
            {
                WeaponType.Base, $@"Weapons/{WeaponType.Base}"
            }
        };
    }
}
