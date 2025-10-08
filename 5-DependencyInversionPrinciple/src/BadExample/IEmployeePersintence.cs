using System.Collections.Generic;

namespace.DependencyInversionPrinciple.src.BadExample
{
	public interface EmployeePersistence
	{
		public List<Employee> FindAll();

		public void Save(Employee employee);
	}
}