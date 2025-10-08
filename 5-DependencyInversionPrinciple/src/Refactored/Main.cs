using System;

namespace InterfaceSegregationPrinciple.src.Refactored;

public class Main
{
    public static void Run()
    {
        Company company = new Company();
        company.AddEmployee(new Employee("Alice Johnson", 60000));
        company.AddEmployee(new Employee("Bob Smith", 75000));
        foreach (var emp in company.GetEmployees())
        {
            Console.WriteLine($"{emp.GetFullName()} earns {emp.GetSalary()}");
        }
    }
}