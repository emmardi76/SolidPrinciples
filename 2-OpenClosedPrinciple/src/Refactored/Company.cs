using System.Collections.Generic;

namespace OpenClosedPrinciple.src.Refactored;

public class Company
{
    private IEmployeePersistence _persistence;

    public Company()
    {
        _persistence = new EmployeeMemoryPersistence();
    }

    public List<Employee> GetEmployees()
    {
        return _persistence.FindAll();
    }

    public void AddEmployee(Employee e)
    {
        _persistence.Save(e);
    }
}