namespace InterfaceSegregationPrinciple.src.Refactored;

// A class that implements the interface but does not need all methods
public class BasicCalculator : IBasicOperations
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
}