namespace Asteroids.Views
{
    public interface IUICommand
    {
        public void Execute();
        public void Cancel();
    }
}
