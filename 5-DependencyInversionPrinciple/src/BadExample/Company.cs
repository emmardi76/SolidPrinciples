using System.Collections.Generic;

namespace.DependencyInversionPrinciple.src.BadExample
{
    private EmployeePersistence persistence;

    public Company()
    {
        persistence = new EmployeeMemoryPersistence();
    }

    public List<Employee> GetEmployees()
    {
        return persistence.FindAll();
    }

    public void AddEmployee(Employee e)
    {
        persistence.Save(e);
    }
}