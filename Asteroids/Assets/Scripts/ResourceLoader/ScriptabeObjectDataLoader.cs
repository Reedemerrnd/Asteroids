using System;
using UnityEngine;

namespace Asteroids.Data
{
    public class ScriptabeObjectDataLoader : IDataLoader
    {

        public IEnemyData LoadEnemy(EnemyType enemyType) => Resources.Load<EnemyData>(ResourcesPath.Enemies[enemyType]);
        public IShipData LoadShip(PlayerShip shipType) => Resources.Load<ShipData>(ResourcesPath.PlayerShips[shipType]);
        public IWeaponData LoadWeapon(WeaponType weaponType) => Resources.Load<WeaponData>(ResourcesPath.Weapons[weaponType]);
    }
}
