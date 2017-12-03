using System;
using System.Collections.Generic;
using Xunit;

namespace Day3.UnitTests
{
    public class SpiralSequenceGeneratorShould
    {
        [Fact]
        public void GenerateNumbersFromSpiralSequence()
        {
            IEnumerable<(int, int)> inputs = new (int,int)[]
            {
                (2, 4),
                (54, 57),
                (747, 806),
                (325489, 330785)
            };

            SpiralSequenceGenerator generator = new SpiralSequenceGenerator();

            foreach ((int input, int expected) in inputs)
            {
                Assert.Equal(expected, generator.GetValueAfter(input));
            }
        }
    }
}