namespace LiskovSubstitutionPrinciple.src.Refactored;

public class LandMammal : Mammal
{
   public override void Move()
   {
       System.Console.WriteLine("Walking on land");
   }
}