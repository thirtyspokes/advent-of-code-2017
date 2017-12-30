using System;
using Xunit;
using Day10;

namespace Day10.UnitTests
{
    public class KnotHashShould
    {
        [Fact]
        public void HashStrings()
        {
            KnotHash kh = new KnotHash();

            Assert.Equal("a2582a3a0e66e6e86e3812dcb672a272", kh.GenerateHash("", 64));
            Assert.Equal("33efeb34ea91902bb2f59c9920caa6cd", kh.GenerateHash("AoC 2017", 64));
            Assert.Equal("3efbe78a8d82f29979031a4aa0b16a9d", kh.GenerateHash("1,2,3", 64));
            Assert.Equal("63960835bcdc130f0b66d7ff4f6a5a8e", kh.GenerateHash("1,2,4", 64));
        }

        [Fact]
        public void ReverseSubsequences()
        {
            KnotHash kh = new KnotHash();

            int[] a = {0, 1, 2, 3, 4};
            kh.ReverseSubsequence(a, 0, 3);
            Assert.Equal(new int[]{2, 1, 0, 3, 4}, a);

            int[] b = {2, 1, 0, 3, 4};
            kh.ReverseSubsequence(b, 3, 4);
            Assert.Equal(new int[]{4, 3, 0, 1, 2}, b);

            int[] c = {4, 3, 0, 1, 2};
            kh.ReverseSubsequence(c, 3, 1);
            Assert.Equal(new int[]{4, 3, 0, 1, 2}, c);

            int[] d = {4, 3, 0, 1, 2};
            kh.ReverseSubsequence(d, 1, 5);
            Assert.Equal(new int[]{3, 4, 2, 1, 0}, d);
        }

        [Fact]
        public void CalculateHashRounds()
        {
            KnotHash kh = new KnotHash();
            var result = kh.PerformHashRounds(new int[]{3, 4, 1, 5}, 1, 5);
            Assert.Equal(12, result[0] * result[1]);
        }

        [Fact]
        public void XORBlocks()
        {
            KnotHash kh = new KnotHash();
            var input = new int[]{65, 27, 9, 1, 4, 3, 40, 50, 91, 7, 6, 0, 2, 5, 68, 22};

            Assert.Equal(64, kh.XORBlock(input));
        }

        [Fact]
        public void PartitionBlocks()
        {
            KnotHash kh = new KnotHash();
            var input = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            var blocks = kh.PartitionList(input, 4);
            Assert.Equal(3, blocks.Count);

            var arrayBlocks = blocks.ToArray();

            Assert.Equal(new int[]{1, 2, 3, 4}, arrayBlocks[0]);
            Assert.Equal(new int[]{5, 6, 7, 8}, arrayBlocks[1]);
            Assert.Equal(new int[]{9, 10, 11, 12}, arrayBlocks[2]);
        }

        [Fact]
        public void GenerateInputSequences()
        {
            KnotHash kh = new KnotHash();
            int[] expected = {49, 44, 50, 44, 51, 17, 31, 73, 47, 23};

            Assert.Equal(expected, kh.GenerateInputSequence("1,2,3"));
        }
    }
}
