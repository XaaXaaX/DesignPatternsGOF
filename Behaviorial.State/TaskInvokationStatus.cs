namespace Behavioral.State
{
    public abstract class TaskInvokationStatus
    {
        public enum TaskInvokationStatusEnum
        {
            Invoked = 0,
            NotInvoked = 1,
            Invoking = 2
        }
        public readonly TaskInvokationStatusEnum CurrentState;

        public TaskInvokationStatus(TaskInvokationStatusEnum state)
        {
            CurrentState = state;
        }
    }
}