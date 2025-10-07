using System.Collections.Generic;

namespace OpenClosedPrinciple.src.BadExample
{
    public class ProgrammerMemoryPersintence
    {
        private List<Programmer> programmers;

        public ProgrammerMemoryPersintence()
        {
            programmers = new List<Programmer>();
        }

        public List<Programmer> FindAll()
        {
            return programmers;
        }

        public void Save(Programmer programmer)
        {
            programmers.Add(programmer);
        }
    }
}
