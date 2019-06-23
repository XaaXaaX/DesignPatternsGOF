namespace Creational.Singleton.Lock
{
    public sealed class EmployeeManager
    {
        private EmployeeManager() { }

        private static EmployeeManager instance;
        private static readonly object instanceLock = new object();

        public EmployeeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        instance = new EmployeeManager();
                    }
                }

                return instance;
            }
        }
    }
}
