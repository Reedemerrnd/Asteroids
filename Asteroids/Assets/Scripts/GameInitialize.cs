using Asteroids.Core;
using Asteroids.Data;
using Asteroids.Models;
using Asteroids.Core.States;
using Controller;
using Inputs;
using Asteroids.Views;

namespace Asteroids
{
    public class GameInitialize
    {
        public GameInitialize(Controllers controllers, PlayerShip type)
        {
            var input = new PCInput();

            var dataLoader = new ScriptabeObjectDataLoader();
            var jsonLoader = new JsonDataLoader();

            var weaponFactory = new WeaponFactory(dataLoader);
            weaponFactory.SetWeapon(WeaponType.Base);
            var weaponModel = weaponFactory.GetModel();
            var lockableWeapon = new LockableWeapon(weaponModel);

            var shipFactory = new ShipFactory(dataLoader);
            shipFactory.SetShip(type, lockableWeapon);
            var playerView = shipFactory.GetView();
            var playerModel = shipFactory.GetModel();

            var shipStateHandler = new ShipStateHandler(new NormalState(new HealthyShipMovement()),
                                                        new DamagedState(new DamagedShipMovement(0.4f)),
                                                        new HeavilyDamagedState(new HeavilyDamagedShipMovement(0.4f, 0.3f)));

            var enemyFactory = new EnemyFactory(dataLoader);
            enemyFactory.Init(EnemyType.Asteroid);
            enemyFactory.Init(EnemyType.SmallAsteroid);

            var enemyModels = enemyFactory.GetModel();
            var enemyPoolSet = enemyFactory.GetView();

            var enemyspawnModel = new EnemySpawnModel();

            var enemyDeathObserver = new EnemyDeathObserver(enemyModels);
            var enemySpawnLogger = new EnemySpawnConsoleLogger();
            var enemySpawnVisitMediator = new EnemySpawnVisitMediator(enemySpawnLogger, enemyDeathObserver);

            var uiFactory = new UIFactory(dataLoader);

            controllers
                .Add(new GamePauseController())
                .Add(new UIController(uiFactory.GetInGameUI(), uiFactory.GetMainMenu(), playerModel, enemyDeathObserver))
                .Add(new PlayerMovementController(playerView, input, playerModel))
                .Add(new WeaponController(playerView, lockableWeapon, input))
                .Add(new EnemySpawnController(enemyPoolSet, enemyModels, enemyspawnModel, enemySpawnVisitMediator))
                .Add(new DamageController(playerView, playerModel.Health))
                .Add(new AbilityController(playerModel, playerView, input))
                .Add(new ShipStateController(playerView, playerModel, shipStateHandler));
        }
    }
}

