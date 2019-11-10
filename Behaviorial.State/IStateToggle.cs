namespace Behavioral.State
{
    public interface IStateToggle
    {
        void TryClose(IState state);
        void Close(IState state);
        void Open(IState state);
    }
}