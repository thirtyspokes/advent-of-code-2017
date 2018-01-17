using System;
using Day12;
using Xunit;

namespace Day12.UnitTests
{
    public class PipeGroupFinderShould
    {
        [Fact]
        public void CalculateGroupSizes()
        {
            var input = @"0 <-> 2
            1 <-> 1
            2 <-> 0, 3, 4
            3 <-> 2, 4
            4 <-> 2, 3, 6
            5 <-> 6
            6 <-> 4, 5
            ";

            PipeGroupFinder finder = new PipeGroupFinder(input);

            Assert.Equal(6, finder.FindGroupMemberCount(0));
        }

        [Fact]
        public void CalculateNumberOfGroups()
        {
            var input = @"0 <-> 2
            1 <-> 1
            2 <-> 0, 3, 4
            3 <-> 2, 4
            4 <-> 2, 3, 6
            5 <-> 6
            6 <-> 4, 5
            ";

            PipeGroupFinder finder = new PipeGroupFinder(input);

            Assert.Equal(2, finder.FindNumberOfGroups());
        }
    }
}
