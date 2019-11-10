using System;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public interface IState
    {
        void Try(CircuitBreaker circuitBreaker);

        void RegisterFailure();

        void RegisterSuccess();

        TResult Run<TResult>(Func<TResult> action, CircuitBreaker circuitBreaker);
    }
}