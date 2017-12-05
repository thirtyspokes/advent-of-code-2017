using System;
using Xunit;
using Day5.Domain;
using Day5.Services;

namespace Day5.UnitTests
{
    public class OffsetJumperShould
    {
        [Fact]
        public void CorrectlyCountJumpsWithIncrementStrategy()
        {
            OffsetJumper jumper = new OffsetJumper(new int[]{0, 3, 0, 1, -3}, new IncrementStrategy());
            Assert.Equal(5, jumper.StepsToExit());
        }

        [Fact]
        public void CorrectlyCountJumpsWithBalancingStrategy()
        {
            OffsetJumper jumper = new OffsetJumper(new int[]{0, 3, 0, 1, -3}, new BalancingStrategy());
            Assert.Equal(10, jumper.StepsToExit());            
        }
    }
}
