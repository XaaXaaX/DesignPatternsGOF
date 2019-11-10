using System;
using System.Threading;

namespace Behavioral.State
{
    public class HalfOpenState : State, IState
    {
        readonly FailureRetrySeverity _FailureRetrySeverity = FailureRetrySeverity.Minimal;

        public HalfOpenState() : base() { }

        public override void RegisterFailure()
        {
            StateToggle.Open(this);
        }

        public override void RegisterSuccess()
        {
            StateToggle.Close(this);
        }

        public override TResult Run<TResult>(Func<TResult> action, CircuitBreaker circuitBreaker)
        {
            return this.TaskInvoker.Invoke(action, this);
        }

        public override void Try(CircuitBreaker circuitBreaker)
        {
            throw new NotImplementedException();
        }
    }
}