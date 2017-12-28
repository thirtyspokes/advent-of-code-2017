using System.Collections.Generic;

namespace Day8.Services
{
    public interface IInputReader
    {
        IEnumerable<string> ReadInput(string input);
    }
}