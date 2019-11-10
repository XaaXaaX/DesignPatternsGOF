using System;

namespace Behavioral.State
{
    public abstract class State : IState
    {
        readonly IInvoker _Invoker;
        readonly IStateToggle _StateToggle;

        protected IInvoker TaskInvoker { get { return _Invoker; } }
        protected IStateToggle StateToggle { get { return _StateToggle; } }

        public State()
        {
            _Invoker = new Invoker();
            _StateToggle = new StateToggle();
        }

        public virtual void RegisterFailure() { }

        public virtual void RegisterSuccess() { }

        public abstract TResult Run<TResult>(Func<TResult> action, CircuitBreaker circuitBreaker);

        public abstract void Try(CircuitBreaker circuitBreaker);
    }
}
