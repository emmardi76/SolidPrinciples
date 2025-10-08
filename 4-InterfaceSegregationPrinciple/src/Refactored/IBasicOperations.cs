namespace InterfaceSegregationPrinciple.src.Refactored
{
    // A single interface with multiple methods
    public interface IBasicOperations
    {
        public Double Add(double a, double b);
        public Double Subtract(double a, double b);
        public Double Multiply(double a, double b);
        public Double Divide(double a, double b);       
    }   
}