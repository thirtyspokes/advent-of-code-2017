using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4.Services
{
    public class FileInputParser : IInputParser
    {
        public FileInputParser()
        {}

        public IEnumerable<string[]> ParseInput(string path)
        {
            string raw = System.IO.File.ReadAllText(path).Trim();
            var lines = raw.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
            return lines.Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries)); 
        }
    }
}