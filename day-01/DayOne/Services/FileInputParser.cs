using System;
using System.Linq;

namespace DayOne.Services
{
    public class FileInputParser : IInputParser
    {
        public FileInputParser()
        {

        }

        public int[] ParseInput(string path)
        {
            var raw = System.IO.File.ReadAllText(path).Trim();
            return raw.Select(x => (int)Char.GetNumericValue(x)).ToArray();
        }
    }
}