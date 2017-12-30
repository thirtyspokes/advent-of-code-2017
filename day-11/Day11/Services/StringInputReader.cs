using System.Collections.Generic;
using System;
using System.Linq;

namespace Day11.Services
{
    public class StringInputReader : IInputReader
    {
        public StringInputReader()
        {
        }

        public IEnumerable<string> ReadInput(string input)
        {
            return input.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
        }
    }
}