using System.Collections.Generic;

namespace Day11.Services
{
    public interface IInputReader
    {
        IEnumerable<string> ReadInput(string input);
    }
}