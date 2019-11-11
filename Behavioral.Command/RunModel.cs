using System;

namespace Behavioral.Command
{
    public class RunModel
    {
        bool HasResult { get; set; }

        bool IsAsync { get; set; }

        bool HasEventualConsitency { get; set; }
    }
}