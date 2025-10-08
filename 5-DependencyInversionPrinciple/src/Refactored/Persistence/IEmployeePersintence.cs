using System.Collections.Generic;

namespace DependencyInversionPrinciple.src.Refactored.Persistence;

public interface IEmployeePersistence
{
	public List<Employee> FindAll();

	public void Save(Employee employee);
}