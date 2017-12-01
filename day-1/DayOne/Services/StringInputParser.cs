using System;
using System.Linq;

namespace DayOne.Services
{
    public class StringInputParser : IInputParser
    {
        public StringInputParser()
        {

        }

        public int[] ParseInput(string input)
        {
            return input.Select(x => (int)Char.GetNumericValue(x)).ToArray();
        }
    }
}