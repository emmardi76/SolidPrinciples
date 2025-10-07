using System.Collections.Generic;

namespace OpenClosedPrinciple.src.BadExample
{
    public class Company
    {
        private ProgrammerMemoryPersintence persistence;

        public Company()
        {
            persistence = new ProgrammerMemoryPersintence();
        }

        public List<Programmer> GetProgrammers()
        {
            return persistence.FindAll();
        }

        public void AddProgrammer(string fullName, int salary)
        {
            persistence.Save(new Programmer(fullName, salary));
        }
    }
}