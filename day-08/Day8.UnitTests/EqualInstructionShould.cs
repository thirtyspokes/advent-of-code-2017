using System;
using Xunit;
using Day8.Domain;

namespace Day8.UnitTests
{
    public class EqualInstructionShould
    {
        [Fact]
        public void ModifyWhenConditionIsMet()
        {
            EqualInstruction a = new EqualInstruction(true);
            EqualInstruction b = new EqualInstruction(false);

            Assert.Equal(0, a.Modify(0, 5, -1, 0));
            Assert.Equal(0, a.Modify(0, 1, 1, 0));
            Assert.Equal(1, a.Modify(0, 1, 0, 0));
            Assert.Equal(6, b.Modify(6, 1, 5, 3));
        }
    }
}