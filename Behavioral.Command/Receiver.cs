using System;

namespace Behavioral.Command
{
    public interface IReceiver
    {
        void Invoke();

        void PrerInvoke();

        void PostInvoke();
    }
}