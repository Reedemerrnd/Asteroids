namespace Asteroids.Models
{
    internal interface ICanMove : IInjectable<IMoveVariant>
    {
        public IMoveVariant Movement { get; }
    }
}
