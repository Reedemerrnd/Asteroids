using Asteroids.Views;

namespace Asteroids.Models
{
    internal interface ICanMoveAndRotate : IInjectable<IMoveAndRotateVariant>
    {
        public IMoveAndRotateVariant Movement { get; }
    }
}
