using System;
using Xunit;
using Day8.Domain;

namespace Day8.UnitTests
{
    public class GTEInstructionShould
    {
        [Fact]
        public void ModifyWhenConditionIsMet()
        {
            GTEInstruction a = new GTEInstruction(true);
            GTEInstruction b = new GTEInstruction(false);

            Assert.Equal(0, a.Modify(0, 5, -1, 0));
            Assert.Equal(1, a.Modify(0, 1, 1, 0));
            Assert.Equal(1, a.Modify(0, 1, 0, 0));
            Assert.Equal(5, b.Modify(6, 1, 5, 3));
        }
    }
}