using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace LiskovSubstitutionPrinciple.src.BadExample;

public class Mammal
{
    private int Weight;
    private int AgeInDays;

    public int GetWeight()
    {
        return Weight;
    }
    public int GetAgeInDays()
    {
        return AgeInDays;
    }
    public void Walk()
    {
        System.Console.WriteLine("Walking");
    }        
}