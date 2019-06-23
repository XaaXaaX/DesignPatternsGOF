namespace Creational.Singleton.SingleCheck
{
    public sealed class EmployeeManager
    {
        private EmployeeManager() { }

        private static EmployeeManager instance;

        public EmployeeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeManager();
                }

                return instance;
            }
        }
    }
}
