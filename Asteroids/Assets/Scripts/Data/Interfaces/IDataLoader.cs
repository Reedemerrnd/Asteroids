

namespace Asteroids.Data

{
    public interface IDataLoader
    {
        public EnemyData LoadEnemy(EnemyType enemyType);
        public ShipData LoadShip(PlayerShip shipType);
        public WeaponData LoadWeapon(WeaponType weaponType);

    }
}
