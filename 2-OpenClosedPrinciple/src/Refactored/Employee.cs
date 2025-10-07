namespace OpenClosedPrinciple.src.Refactored
{
    public class Employee
    {
        public string FullName { get; }
        public int Salary { get; }

        public Employee(string fullName, int salary)
        {
            FullName = fullName;
            Salary = salary;
        }
    }
}