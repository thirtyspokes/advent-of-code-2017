using System.Collections.Generic;
using System.Linq;
using Day16.Domain;

namespace Day16.Services
{
    public class DanceExecutor
    {
        private readonly char[] _programs;

        public DanceExecutor(char[] startingPrograms)
        {
            _programs = startingPrograms;
        }

        public char[] Execute(IEnumerable<IDanceStep> steps)
        {
            var programs = _programs.Select(x => x).ToArray();

            foreach (var step in steps)
            {
                programs = step.ApplyStep(programs);
            }

            return programs;
        }
    }
}