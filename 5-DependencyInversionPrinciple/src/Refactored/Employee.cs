namespace.DependencyInversionPrinciple.src.Refactored;

public class Employee
{
    private string FullName;
    private decimal Salary;

    public Employee(string fullName, decimal salary)
    {
        FullName = fullName;
        Salary = salary;
    }

    public string GetFullName()
    {
        return FullName;
    }

    public string GetSalary()
    {
        return Salary.ToString("C");
    }
}