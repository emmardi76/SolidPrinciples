using DependencyInversionPrinciple.src.Refactored.Persistence;

namespace DependencyInversionPrinciple.src.Refactored.Factory;

public interface IEmployeePersistenceFactory
{
    public IEmployeePersistence GetEmployeePersistence();
}