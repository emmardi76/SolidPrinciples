namespace LiskovSubstitutionPrinciple.src.BadExample;

public class  Dolphin extends Mammal
{
    @Override
    public void Walk()
    {
        throw new System.NotImplementedException("Dolphins can't walk");
    }

}