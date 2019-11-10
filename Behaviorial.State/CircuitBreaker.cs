using System;

namespace Behavioral.State
{
    public class CircuitBreaker
    {
        readonly TimeSpan _TimeOut;
        public IState state { get; set; }

        public IState _
        {
            get => default;
            set
            {
            }
        }

        public CircuitBreaker()
        {
            state = new CloseState(_TimeOut);
        }

        public void Invoke<T>(Func<T> action)
        {
            state.Run(action, this);
        }
    }
}
