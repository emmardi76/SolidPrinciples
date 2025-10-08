namespace LiskovSubstitutionPrinciple.src.Refactored;

public class Dolphin: Mammal
{
   public override void Move()
   {
       System.Console.WriteLine("Swimming");
   }
}