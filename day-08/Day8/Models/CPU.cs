using System.Collections.Generic;
using System.Linq;

namespace Day8.Models
{
    public class CPU
    {
        private Dictionary<string, int> _registers;
        private int _maxStoredValue;

        public CPU()
        {
            _registers = new Dictionary<string, int>();
            _maxStoredValue = 0;
        }

        public void SetRegisterValue(string name, int value)
        {
            _registers[name] = value;

            if (_registers[name] > _maxStoredValue)
            {
                _maxStoredValue = value;
            }
        }

        public int GetRegisterValue(string name)
        {
            if (!_registers.ContainsKey(name))
            {
                _registers[name] = 0;
            }

            return _registers[name];
        }

        public int GetCurrentLargestRegisterValue()
        {
            return _registers.Values.Max();
        }

        public int GetHistoricalLargestRegisterValue()
        {
            return _maxStoredValue;
        }
    }
}