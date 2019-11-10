using System;
using System.Threading;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public class CloseState : State, IState
    {
        readonly TimeSpan _TimeOut;
        int _FailureOccured;
        readonly FailureRetrySeverity _FailureRetrySeverity = FailureRetrySeverity.Minimal;

        public CloseState() :
            this(new TimeSpan(0, 0, 10))
        { }
        
        public CloseState(TimeSpan timeout) : base() => this._TimeOut = timeout;

        public override void RegisterFailure()
        {
            if (Interlocked.Increment(ref _FailureOccured) >= (int)_FailureRetrySeverity)
            {
                StateToggle.Open(this);
            }
        }

        public override void RegisterSuccess()
        {
            this._FailureOccured = 0;
        }

        public override TResult Run<TResult>(Func<TResult> action, CircuitBreaker circuitBreaker)
        {
            return this.TaskInvoker.Invoke(action, new TimeSpan(0, 0, 10), this);
        }

        public override void Try(CircuitBreaker circuitBreaker)
        {
            _FailureOccured = 0;
        }
    }
}