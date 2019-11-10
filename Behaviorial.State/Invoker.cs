using System;
using System.Threading;
using System.Threading.Tasks;

namespace Behavioral.State
{
        public class Invoker : IInvoker
        {
            private readonly TaskScheduler _Schaduler = TaskScheduler.Default;
            private Timer _timer;


            public void InvokePlanified(Action methodCall, TimeSpan interval)
            {
                if (methodCall == null) throw new ArgumentNullException();

                _timer = new Timer(_ => methodCall(),
                                        null,
                                        interval,
                                        new TimeSpan(0, 0, 0, -1));
            }


            public T Invoke<T>(Func<T> methodCall, TimeSpan timeout, IState state)
            {
                try
                {
                    T result = Invoke(methodCall, timeout);
                    state.RegisterSuccess();
                    return result;
                }
                catch (Exception)
                {
                    state.RegisterFailure();
                    throw;
                }
            }

            public T Invoke<T>(Func<T> methodCall, IState state)
            {
                try
                {
                    T result = Invoke(methodCall, -1);
                    state.RegisterSuccess();
                    return result;
                }
                catch (Exception)
                {
                    state.RegisterFailure();
                    throw;
                }
            
            }

            private T Invoke<T>(Func<T> methodCall, TimeSpan timeout)
            {
               return  Invoke(methodCall, (int)timeout.TotalMilliseconds);
            }

            private T Invoke<T>(Func<T> methodCall, int MillisecondsToWait)
            {
                CancellationTokenSource cntkn;

                if (methodCall == null)
                    throw new ArgumentNullException();

                cntkn = new CancellationTokenSource();
                var tkn = cntkn.Token;

                var task = Task<T>.Factory.StartNew(methodCall, tkn, TaskCreationOptions.None, _Schaduler);

                if (task.IsCompleted || task.Wait(MillisecondsToWait, tkn))
                    return task.Result;

                cntkn.Cancel();
                throw new TimeoutException();
            }
        }
}
