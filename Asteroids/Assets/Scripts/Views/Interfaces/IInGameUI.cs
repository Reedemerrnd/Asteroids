namespace Asteroids.Views
{
    public interface IInGameUI
    {
        public void SetHp(string health);
        public void SetScore(string score);
        public void ShowLog(string message);
    }
}
