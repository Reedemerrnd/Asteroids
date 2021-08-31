using Asteroids.Data;
using Asteroids.Models;
using Controller;
using Inputs;

namespace Asteroids
{
    public class GameInitialize
    {
        public GameInitialize(Controllers controllers)
        {
            var input = new PCInput();
            var dataLoader = new ScriptabeObjectDataLoader();

            var weaponFactory = new WeaponFactory(dataLoader);
            weaponFactory.SetWeapon(WeaponType.Base);
            var weaponModel = weaponFactory.GetModel();
            var lockableWeapon = new LockableWeapon(weaponModel);

            var shipFactory = new ShipFactory(dataLoader);
            shipFactory.SetShip(PlayerShip.Base, lockableWeapon);

            var enemyFactory = new EnemyFactory(dataLoader);
            enemyFactory.Init(EnemyType.Asteroid);
            enemyFactory.Init(EnemyType.SmallAsteroid);

            var enemyModels = enemyFactory.GetModel();
            var enemyPoolSet = enemyFactory.GetView();

            var enemyspawnModel = new EnemySpawnModel();


            var playerView = shipFactory.GetView();
            var playerModel = shipFactory.GetModel();

            controllers
                .Add(new PlayerMovementController(playerView, input, playerModel))
                .Add(new WeaponController(playerView, lockableWeapon, input))
                .Add(new EnemySpawnController(enemyPoolSet,enemyModels, enemyspawnModel))
                .Add(new DamageController(playerView, playerModel.Health))
                ;

        }
    }
}

