using System;
using Day10;
using Day14.Services;
using Xunit;

namespace Day14.UnitTests
{
    public class GridCreatorShould
    {
        [Fact]
        public void GenerateGrids()
        {
            KnotHash kh = new KnotHash();
            GridCreator g = new GridCreator(kh);
            var grid = g.Generate("flqrgnkx");

            Assert.Equal(128, grid.Length);
            
            foreach (var row in grid)
            {
                Assert.Equal(128, row.Length);
            }
        }
    }
}
