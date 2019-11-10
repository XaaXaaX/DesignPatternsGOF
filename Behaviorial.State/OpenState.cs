using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.State
{
    public class OpenState : State, IState
    {
        readonly TimeSpan _TimeOut;
        int _FailureOccured;
        readonly FailureRetrySeverity _FailureRetrySeverity = FailureRetrySeverity.Minimal;

        public OpenState()
            : this(new TimeSpan(0, 0, 30))
        { }

        public OpenState(TimeSpan timeout)
            : base()
        {
            this._TimeOut = timeout;
        }

        public override TResult Run<TResult>(Func<TResult> action, CircuitBreaker circuitBreaker)
        {
            throw new ExecutionEngineException();
        }

        public override void Try(CircuitBreaker circuitBreaker)
        {
            TaskInvoker.InvokePlanified(
                () => StateToggle.TryClose(this),
                _TimeOut);
        }
    }
}
