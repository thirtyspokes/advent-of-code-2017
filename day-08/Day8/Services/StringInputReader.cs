using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8.Services
{
    public class StringInputReader : IInputReader
    {
        public StringInputReader()
        {
        }

        public IEnumerable<string> ReadInput(string input)
        {
            return input.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
        }
    }
}