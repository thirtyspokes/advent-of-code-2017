using System.Collections.Generic;

namespace Day7.Services
{
    public interface IInputReader
    {
        IEnumerable<string> ReadInput(string input);
    }
}