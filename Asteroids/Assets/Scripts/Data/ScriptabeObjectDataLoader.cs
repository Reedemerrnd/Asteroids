using UnityEngine;

namespace Asteroids.Data
{
    public class ScriptabeObjectDataLoader : IDataLoader
    {

        public EnemyData LoadEnemy(EnemyType enemyType) => Resources.Load<EnemyData>(ResourcesPath.Enemies[enemyType]);
        public ShipData LoadShip(PlayerShip shipType) => Resources.Load<ShipData>(ResourcesPath.PlayerShips[shipType]);
        public WeaponData LoadWeapon(WeaponType weaponType) => Resources.Load<WeaponData>(ResourcesPath.Weapons[weaponType]);
    }
}
