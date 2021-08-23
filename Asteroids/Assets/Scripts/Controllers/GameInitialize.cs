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
            var dataLoader = new ScriptabeObjectDataLoader();

            var shipFactory = new ShipFactory(dataLoader);
            shipFactory.Init(PlayerShip.Base);

            var enemyInitializer = new EnemyInitializer(dataLoader);
            enemyInitializer.Init(EnemyType.Asteroid)
                            .Init(EnemyType.SmallAsteroid);
            var enemyModels = enemyInitializer.GetModels();
            var enemyPool = enemyInitializer.GetViewsPool();
            var enemyViewsList = new SpawnedPoolObjectsList<EnemyType>(enemyPool);
            var enemyspawnModel = new EnemySpawnModel();

            var weaponData = dataLoader.LoadWeapon(WeaponType.Base);
            var mainWeaponAmmoPool = new Pool(weaponData.AmmoPrefab.GetComponent<IPoolObject>());
            var weaponModel = new PrimaryWeapon(weaponData);

            var input = new PCInput();
            var playerView = shipFactory.GetView();
            var playerModel = shipFactory.GetModel();

            controllers.Add(new PlayerMovementController(playerView, input, playerModel))
                       .Add(new WeaponController(playerView, weaponModel, input, mainWeaponAmmoPool))
                       .Add(new EnemyMovementController(enemyPool,enemyModels, enemyspawnModel));

        }
    }
}

