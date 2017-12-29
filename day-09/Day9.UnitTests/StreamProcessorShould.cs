using System;
using Xunit;
using Day9;

namespace Day9.UnitTests
{
    public class StreamProcessorShould
    {
        [Fact]
        public void CalculateScoreGroupsFromInput()
        {
            StreamProcessor p = new StreamProcessor();

            Assert.Equal(1, p.ProcessStreamScore("{}"));
            Assert.Equal(6, p.ProcessStreamScore("{{{}}}"));
            Assert.Equal(5, p.ProcessStreamScore("{{},{}}"));
            Assert.Equal(16, p.ProcessStreamScore("{{{},{},{{}}}}"));
            Assert.Equal(1, p.ProcessStreamScore("{<a>,<a>,<a>,<a>}"));
            Assert.Equal(9, p.ProcessStreamScore("{{<ab>},{<ab>},{<ab>},{<ab>}}"));
            Assert.Equal(9, p.ProcessStreamScore("{{<!!>},{<!!>},{<!!>},{<!!>}}"));
            Assert.Equal(3, p.ProcessStreamScore("{{<a!>},{<a!>},{<a!>},{<ab>}}"));
        }

        [Fact]
        public void CountGarbageLength()
        {
            StreamProcessor p = new StreamProcessor();

            Assert.Equal(0, p.ProcessGarbageLength("<>"));
            Assert.Equal(17, p.ProcessGarbageLength("<random characters>"));
            Assert.Equal(3, p.ProcessGarbageLength("<<<<>y"));
            Assert.Equal(2, p.ProcessGarbageLength("<{!>}>"));
            Assert.Equal(0, p.ProcessGarbageLength("<!!>"));
            Assert.Equal(0, p.ProcessGarbageLength("<!!!>>"));
            Assert.Equal(10, p.ProcessGarbageLength("<{o'i!a,<{i<a>"));
        }
    }
}
