using System;
using System.Linq;

namespace Day5.Services
{
    public class FileInputParser
    {
        public FileInputParser()
        {
        }

        public int[] ParseFile(string path)
        {
            return System.IO.File.ReadAllText(path)
                .Split("\n", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Int32.Parse(x))
                .ToArray();
        }
    }
}