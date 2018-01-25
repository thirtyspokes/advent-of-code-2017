using System;
using Xunit;
using Day15.Models;
using Day15.Domain;

namespace Day15.UnitTests
{
    public class JudgeShould
    {
        [Fact]
        public void CountPairsFromGenerators()
        {
            Generator first = new Generator(65, 16807, new SimpleValueStrategy());
            Generator second = new Generator(8921, 48271, new SimpleValueStrategy());
            Judge judge = new Judge(first, second, 40_000_000);

            Assert.Equal(588, judge.CountPairs());
        }
    }
}