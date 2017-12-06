using System;
using Xunit;

namespace Day6.UnitTests
{
    public class BlockMemoryBankShould
    {
        [Fact]
        public void ReallocateMemoryAndReturnSteps()
        {
            BlockMemoryBank bank = new BlockMemoryBank(new int[]{0, 2, 7, 0});
            Assert.Equal(5, bank.CountReallocationCycles());
        }

        [Fact]
        public void ReallocateMemoryAndIdentifyLoopLength()
        {
            BlockMemoryBank bank = new BlockMemoryBank(new int[]{0, 2, 7, 0});
            Assert.Equal(4, bank.CountReallocationLoopLength());
        }
    }
}
