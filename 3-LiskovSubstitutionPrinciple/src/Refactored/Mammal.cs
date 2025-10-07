using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace LiskovSubstitutionPrinciple.src.Refactored
{
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
    }
}