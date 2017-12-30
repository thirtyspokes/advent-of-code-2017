using System.Collections.Generic;
using System;
using System.Linq;

namespace Day11.Services
{
    public class FileInputReader : IInputReader
    {
        public FileInputReader()
        {
        }

        public IEnumerable<string> ReadInput(string path)
        {
            var input = System.IO.File.ReadAllText(path).Trim();
            return input.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
        }
    }
}