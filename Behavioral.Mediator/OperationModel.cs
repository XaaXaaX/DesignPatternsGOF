using System;

namespace Behavioral.Mediator
{
    public class OperationModel
    {
        public string Details { get; internal set; }
        public DateTime Date { get; internal set; }
        public string Title { get; internal set; }

        public override string ToString()
        {
            return $"{Title} at {Date} \n {Details}";
        }
    }
}