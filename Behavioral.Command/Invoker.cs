using System;

namespace Behavioral.Command
{
    public class Invoker<T>
    {
        private readonly ICommand<T> command;

        public Invoker(ICommand<T> command)
        {
            this.command = command;
        }

        public T InvokeCommand(T model)
        {
            return this.command.Execute(model);
        }

    }
}
