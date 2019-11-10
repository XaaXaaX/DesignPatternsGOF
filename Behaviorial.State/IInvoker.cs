using System;

namespace Behavioral.State
{
    public interface IInvoker
    {
        void InvokePlanified(Action methodCall, TimeSpan interval);

        T Invoke<T>(Func<T> methodCall, TimeSpan timeout, IState state);

        T Invoke<T>(Func<T> methodCall, IState state);
    }
}