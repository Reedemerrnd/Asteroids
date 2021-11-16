using Asteroids.Views;
using UnityEngine;

namespace Asteroids.Data
{
    internal sealed class ScriptabeObjectDataLoader : IDataLoader
    {

        public EnemyData LoadEnemy(EnemyType enemyType) => Resources.Load<EnemyData>(ResourcesPath.Enemies[enemyType]);
        public BaseUI LoadInGameUI() => Resources.Load<BaseUI>("UI/InGameUI");
        public BaseUI LoadMainMenu() => Resources.Load<BaseUI>("UI/MainMenu");
        public ShipData LoadShip(PlayerShip shipType) => Resources.Load<ShipData>(ResourcesPath.PlayerShips[shipType]);
        public WeaponData LoadWeapon(WeaponType weaponType) => Resources.Load<WeaponData>(ResourcesPath.Weapons[weaponType]);

    }
}
