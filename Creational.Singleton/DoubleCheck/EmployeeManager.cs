namespace Creational.Singleton.DoubleCheck
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
                        if (instance == null)
                        {
                            instance = new EmployeeManager();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
