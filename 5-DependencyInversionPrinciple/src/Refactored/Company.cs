using System.Collections.Generic;

namespace DependencyInversionPrinciple.src.Refactored;

public class Company()
{
    private EmployeePersistence persistence;

    public Company(EmployeeePersistenceFactory persistenceFactory)
    {
        persistence = persistenceFactory.GetEmployeePersistence();
    }

    public void AddEmployee(Employee e)
    {
        persistence.Save(e);
    }
}