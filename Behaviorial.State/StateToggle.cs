namespace Behavioral.State
{
    internal class StateToggle : IStateToggle
    {
        public void Close(IState state)
        {
            state = new CloseState();
        }

        public void Open(IState state)
        {
            state = new OpenState();
        }

        public void TryClose(IState state)
        {
            throw new System.NotImplementedException();
        }
    }
}