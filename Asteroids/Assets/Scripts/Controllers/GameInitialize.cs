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
            var enemyFactory = new EnemyInitializer(dataLoader);
            enemyFactory.Init(EnemyType.Asteroid);

            var weaponData = dataLoader.LoadWeapon(WeaponType.Base);
            var enemyData = dataLoader.LoadEnemy(EnemyType.Asteroid);

            var mainWeaponAmmoPool = new Pool(weaponData.AmmoPrefab.GetComponent<IPoolObject>());
            var asteroidPool = enemyFactory.GetViewsPool();

            var input = new PCInput();
            var playerView = shipFactory.GetView();
            var weaponModel = new PrimaryWeapon(weaponData);
            var playerModel = shipFactory.GetModel();

            controllers.Add(new PlayerMovementController(playerView, input, playerModel))
                       .Add(new WeaponController(playerView, weaponModel, input, mainWeaponAmmoPool))
                       .Add(new EnemyMovementController(asteroidPool));

        }
    }
}

