using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4.Services
{
    public class StringInputParser : IInputParser
    {
        public StringInputParser()
        {}

        public IEnumerable<string[]> ParseInput(string input)
        {
            var lines = input.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
            return lines.Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }
    }
}