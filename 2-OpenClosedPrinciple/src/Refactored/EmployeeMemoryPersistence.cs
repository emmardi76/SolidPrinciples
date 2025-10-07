using System.Collections.Generic;

namespace OpenClosedPrinciple.src.Refactored
{
    public class EmployeeMemoryPersistence : IEmployeePersistence
    {
        private List<Employee> _employees;

        public EmployeeMemoryPersistence()
        {
            _employees = new List<Employee>();
        }

        public List<Employee> FindAll()
        {
            return _employees;
        }

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}