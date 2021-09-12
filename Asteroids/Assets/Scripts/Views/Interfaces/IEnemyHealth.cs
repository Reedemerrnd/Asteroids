using Asteroids.Data;
using System;

namespace Asteroids.Views
{
    //каким-нибудь образом заменить
    public interface IEnemyHealth
    {
        public int Health { get; set; }
        public void SubscribeOnDeath(Action<EnemyType> subscriber);
    }
}
