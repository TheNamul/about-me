namespace GameForge.Core
{
    public interface IDashable
    {
        bool IsDashing { get; }
        bool CanDash { get; }
        void Dash();
    }
}