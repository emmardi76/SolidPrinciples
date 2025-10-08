namespace InterfaceSegregationPrinciple.src.BadExample;

// A single interface with multiple methods
public interface IOperations
{
    public double Add(double a, double b);
    public double Subtract(double a, double b);
    public double Multiply(double a, double b);
    public double Divide(double a, double b);
    public double Sine(double angle);
    public double Cosine(double angle);
}   