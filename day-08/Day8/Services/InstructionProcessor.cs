using Day8.Models;
using Day8.Domain;
using System;
using System.Linq;

namespace Day8.Services
{
    public class InstructionProcessor
    {
        private readonly CPU _cpu;
        private readonly IInputReader _reader;

        public InstructionProcessor(CPU cpu, IInputReader reader)
        {
            _cpu = cpu;
            _reader = reader;
        }

        public void ProcessInstructions(string input)
        {
            var lines = _reader.ReadInput(input);

            foreach (string line in lines)
            {
                // Get the components from the line.
                var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                if (parts.Count() != 7)
                {
                    throw new FormatException("The input '" + line + "' is not in a valid format.");
                }

                var isAddition = parts[1] == "inc";
                var instruction = _getInstruction(isAddition, parts[5]);
                var registerToChange = parts[0];
                var amount = Int32.Parse(parts[2]);
                var compareTarget = parts[4];
                var compareValue = Int32.Parse(parts[6]);

                // Invoke the parsed instruction.
                var newValue = instruction.Modify(_cpu.GetRegisterValue(registerToChange), amount, _cpu.GetRegisterValue(compareTarget), compareValue);

                // Set the new value in the register.
                _cpu.SetRegisterValue(registerToChange, newValue);
            }
        }

        public int GetCurrentLargestValue()
        {
            return _cpu.GetCurrentLargestRegisterValue();
        }

        public int GetHistoricalLargestValue()
        {
            return _cpu.GetHistoricalLargestRegisterValue();
        }

        private IRegisterInstruction _getInstruction(bool isAddition, string op)
        {
            switch (op)
            {
                case ">":
                    return new GreaterThanInstruction(isAddition);
                case ">=":
                    return new GTEInstruction(isAddition);
                case "<":
                    return new LessThanInstruction(isAddition);
                case "<=":
                    return new LTEInstruction(isAddition);
                case "==":
                    return new EqualInstruction(isAddition);
                case "!=":
                    return new NotEqualInstruction(isAddition);
                default:
                    throw new InvalidOperationException(op + " is not a recognized instruction operator.");
            }
        }
    }
}