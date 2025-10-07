namespace LiskovSubstitutionPrinciple.src.BadExample
{
    public class CannotWalkException : System.Exception
    {
        public CannotWalkException() : base("This animal cannot walk.")
        {
        }
    }
}