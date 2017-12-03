using System;
using System.Collections.Generic;
using Xunit;

namespace Day3.UnitTests
{
    public class ManhattanCalculatorShould
    {
        [Fact]
        public void CalculateManhattanDistance()
        {
            IEnumerable<(int, int)> inputs = new (int,int)[]
            {
                (1, 0),
                (12, 3),
                (23, 2),
                (1024, 31),
                (325489, 552)
            };

            foreach ((int input, int expected) in inputs)
            {
                ManhattanCalculator calc = new ManhattanCalculator(input);
                Assert.Equal(expected, calc.ManhattanDistance());
            }
        }
    }
}
