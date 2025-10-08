namespace OpenClosedPrinciple.src.BadExample;

public class Programmer
{
    private string fullName;
    private int salary;

    public Programmer(string fullName, int salary)
    {
        this.fullName = fullName;
        this.salary = salary;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public int GetSalary()
    {
        return salary;
    }
}