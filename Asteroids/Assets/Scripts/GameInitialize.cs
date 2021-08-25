using Controller;
using Inputs;
using System.Linq;
using Asteroids.Models;
using Asteroids.Data;
using Asteroids.Views;
using UnityEngine;

namespace Asteroids
{
    public class GameInitialize
    {
        public GameInitialize(Controllers controllers)
        {
            var input = new PCInput();
            var dataLoader = new ScriptabeObjectDataLoader();

            var shipFactory = new ShipFactory(dataLoader);
            shipFactory.SetShip(PlayerShip.Base);

            var enemyFactory = new EnemyFactory(dataLoader);
            enemyFactory.Init(EnemyType.Asteroid);
            enemyFactory.Init(EnemyType.SmallAsteroid);

            var enemyModels = enemyFactory.GetModel();
            var enemyPoolSet = enemyFactory.GetView();

            var enemyspawnModel = new EnemySpawnModel();

            var weaponData = dataLoader.LoadWeapon(WeaponType.Base);
            var mainWeaponAmmoPool = new Pool(weaponData.AmmoPrefab.GetComponent<IPoolObject>());
            var weaponModel = new PrimaryWeapon(weaponData);

            var playerView = shipFactory.GetView();
            var playerModel = shipFactory.GetModel();

            controllers
                .Add(new PlayerMovementController(playerView, input, playerModel))
                .Add(new WeaponController(playerView, weaponModel, input, mainWeaponAmmoPool))
                .Add(new EnemySpawnController(enemyPoolSet,enemyModels, enemyspawnModel))
                .Add(new DamageController(playerView, playerModel))
                ;

        }
    }
}

