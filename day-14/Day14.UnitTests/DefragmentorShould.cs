using System;
using Day10;
using Day14.Services;
using Xunit;

namespace Day14.UnitTests
{
    public class DefragmentorShould
    {
        [Fact]
        public void ShouldCalculateUsedSpace()
        {
            KnotHash kh = new KnotHash();
            GridCreator g = new GridCreator(kh);
            var grid = g.Generate("flqrgnkx");
            
            Defragmentor f = new Defragmentor();
            Assert.Equal(8108, f.GetUsedSpace(grid));
        }

        [Fact]
        public void ShouldCountConnectedComponents()
        {
            KnotHash kh = new KnotHash();
            GridCreator g = new GridCreator(kh);
            var grid = g.Generate("flqrgnkx");
            
            Defragmentor f = new Defragmentor();
            Assert.Equal(1242, f.CountUsedGroups(grid));
        }
    }
}
