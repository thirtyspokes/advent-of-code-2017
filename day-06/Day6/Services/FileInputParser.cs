using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6.Services
{
    public class FileInputParser
    {
        public FileInputParser()
        {
        }

        public IEnumerable<int> ParseInput(string path)
        {
            var raw = System.IO.File.ReadAllText(path).Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return raw.Select(x => Int32.Parse(x));
        }
    }
}