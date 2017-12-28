using System;
using Xunit;
using Day8.Domain;
using Day8.Models;
using Day8.Services;

namespace Day8.UnitTests
{
    public class InstructionProcessorShould
    {
        [Fact]
        public void ProcessInstructions()
        {
            CPU cpu = new CPU();
            StringInputReader reader = new StringInputReader();
            InstructionProcessor processor = new InstructionProcessor(cpu, reader);

            string input = @"b inc 5 if a > 1
                a inc 1 if b < 5
                c dec -10 if a >= 1
                c inc -20 if c == 10";

            processor.ProcessInstructions(input);

            Assert.Equal(1, processor.GetCurrentLargestValue());
            Assert.Equal(10, processor.GetHistoricalLargestValue());
        }
    }
}