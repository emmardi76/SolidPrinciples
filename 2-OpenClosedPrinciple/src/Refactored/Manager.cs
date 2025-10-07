namespace OpenClosedPrinciple.src.Refactored
{
    public class Manager : Employee
    {
        public int Bonus { get; }

        public Manager(string fullName, int salary, int bonus)
            : base(fullName, salary)
        {
            Bonus = bonus;
        }
    }
}