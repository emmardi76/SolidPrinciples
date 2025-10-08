namespace.DependencyInversionPrinciple.src.BadExample
{
    public class Employee
    {
        public string FullName { get; set; }
        public decimal Salary { get; set; }
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
}