namespace DependencyInversionPrinciple.src.BadExample
{
    public class EmployeeMemoryPersistence : IEmployeePersistence
    {
        private List<Employee> employees;

        public EmployeeMemoryPersistence()
        {
            employees = new List<Employee>();
        }

        public List<Employee> FindAll()
        {
            return employees;
        }
        public override void Save(Employee employee)
        {
            employees.Add(employee);
        }
    }
}