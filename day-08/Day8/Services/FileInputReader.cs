using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8.Services
{
    public class FileInputReader : IInputReader
    {
        public FileInputReader()
        {
        }

        public IEnumerable<string> ReadInput(string path)
        {
            var raw = System.IO.File.ReadAllText(path);
            return raw.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());
        }
    }
}