namespace InterfaceSegregationPrinciple.src.BadExample
{
    // A class that implements the interface but does not need all methods
    public class BasicCalculator : Operations
    { 
        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override double Subtract(double a, double b)
        {
            return a - b;
        }

        public override double Multiply(double a, double b)
        {
            return a * b;
        }

        public override double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

        public override double Sine(double angle)
        {
            throw new NotImplementedException("Sine operation is not supported.");
        }

        public override double Cosine(double angle)
        {
            throw new NotImplementedException("Cosine operation is not supported.");
        }
    }
}