namespace Game.Core
{
    public interface IDashable
    {
        void Dash();
        bool CanDash { get; }
    }
}