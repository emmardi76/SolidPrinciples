using System;
using System.Collections.Generic;
using DependencyInversionPrinciple.src.Refactored;

namespace DependencyInversionPrinciple.src.Refactored.Persistence;

public class MySqlEmployeePersistence : IEmployeePersistence
{
    public List<Employee> FindAll()
    {
        // Simulate fetching employees from a MySQL database
        Console.WriteLine("Fetching employees from MySQL database...");
        return new List<Employee>
        {
            new Employee("Charlie Brown", 50000),
            new Employee("Diana Prince", 80000)
        };
    }
    public void Save(Employee employee)
    {
        // Simulate saving an employee to a MySQL database
        Console.WriteLine($"Saving {employee.GetFullName()} to MySQL database...");
    }
}