namespace InterfaceSegregationPrinciple.src.BadExample
{
    // A single interface with multiple methods
    public interface IOperations
    {
        public Double Add(double a, double b);
        public Double Subtract(double a, double b);
        public Double Multiply(double a, double b);
        public Double Divide(double a, double b);
        public Double Sine(double angle);
        public Double Cosine(double angle);
    }   
}