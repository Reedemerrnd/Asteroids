

namespace Asteroids.Data

{
    public interface IDataLoader
    {
        public IEnemyData LoadEnemy(EnemyType enemyType);
        public IShipData LoadShip(PlayerShip shipType);
        public IWeaponData LoadWeapon(WeaponType weaponType);

    }
}
