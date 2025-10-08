using DependencyInversionPrinciple.src.Refactored.Persistence;

namespace DependencyInversionPrinciple.src.Refactored.Factory;

public class EmployeeMemoryPersistenceFactory : IEmployeePersistenceFactory
{
    public override IEmployeePersistence GetEmployeePersistence()
    {
        return new EmployeeMemoryPersistence();
    }
}