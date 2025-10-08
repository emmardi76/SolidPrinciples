using System.Collections.Generic;

namespace OpenClosedPrinciple.src.Refactored
{
    public interface IEmployeePersistence
    {
        List<Employee> FindAll();
        void Save(Employee employee);
    }
}