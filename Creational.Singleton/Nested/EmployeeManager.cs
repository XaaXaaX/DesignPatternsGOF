namespace Creational.Singleton.Nested
{
    public sealed class EmployeeManager
    {
        private EmployeeManager() { }


        class EmployeeManagerGenerator
        {
            internal static readonly EmployeeManager instance = new EmployeeManager();
        }
        public EmployeeManager Instance
        {
            get
            {
                return EmployeeManagerGenerator.instance;

            }
        }
    }
}
