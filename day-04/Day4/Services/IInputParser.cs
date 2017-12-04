using System.Collections.Generic;

namespace Day4.Services
{
    public interface IInputParser
    {
        IEnumerable<string[]> ParseInput(string input);
    }
}