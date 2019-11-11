using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Command
{
    public interface ICommand<T>
    {
        T Execute(T model);
    }

    public class RunCommand<T>: ICommand<T>
        where T: RunModel
    {
        private readonly IReceiver receiver;

        public RunCommand(IReceiver rec)
            => this.receiver = rec;

        public T Execute(T model)
        {
            receiver.Invoke();
            return model;
        }
    }

    public class AddCommand<T> : ICommand<T>
    where T : RunModel
    {
        private readonly IReceiver receiver;

        public AddCommand(IReceiver rec)
            => this.receiver = rec;

        public T Execute(T model)
        {
            receiver.Invoke();
            return model;
        }
    }
}
