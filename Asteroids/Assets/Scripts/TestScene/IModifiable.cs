namespace Asteroids.Test
{
    internal interface IModifiable<T>
    {
        public void AddMod(T mod);
        public void Remove(T mod);
    }
}
