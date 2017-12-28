using System;
using Xunit;
using Day8.Domain;

namespace Day8.UnitTests
{
    public class LessThanInstructionShould
    {
        [Fact]
        public void ModifyWhenConditionIsMet()
        {
            LessThanInstruction a = new LessThanInstruction(true);
            LessThanInstruction b = new LessThanInstruction(false);

            Assert.Equal(5, a.Modify(0, 5, -1, 0));
            Assert.Equal(0, a.Modify(0, 1, 1, 0));
            Assert.Equal(0, a.Modify(0, 1, 0, 0));
            Assert.Equal(5, b.Modify(6, 1, 3, 5));
        }
    }
}