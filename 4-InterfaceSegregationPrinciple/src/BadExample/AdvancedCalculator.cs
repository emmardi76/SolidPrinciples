using System;

namespace InterfaceSegregationPrinciple.src.BadExample;

public class AdvancedCalculator : Operations
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
        return Math.Sin(angle);
    }
    public override double Cosine(double angle)
    {
        return Math.Cos(angle);
    }
}