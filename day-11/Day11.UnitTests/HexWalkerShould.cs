using Day11.Services;
using System;
using Xunit;

namespace Day11.UnitTests
{
    public class HexWalkerShould
    {
        [Fact]
        public void CalculateDistancesBetweenTiles()
        {
            StringInputReader reader = new StringInputReader();
            HexWalker walker = new HexWalker(reader);

            Assert.Equal(3, walker.ShortestDistanceFromStart("ne,ne,ne"));
            Assert.Equal(0, walker.ShortestDistanceFromStart("ne,ne,sw,sw"));
            Assert.Equal(2, walker.ShortestDistanceFromStart("ne,ne,s,s"));
            Assert.Equal(3, walker.ShortestDistanceFromStart("se,sw,se,sw,sw"));
        }
    }
}
