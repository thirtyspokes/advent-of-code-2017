using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7.Services
{
    public class FileInputReader : IInputReader
    {
        public FileInputReader()
        {
        }

        public IEnumerable<string> ReadInput(string path)
        {
            var input = System.IO.File.ReadAllText(path);
            return input.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
        }
    }
}