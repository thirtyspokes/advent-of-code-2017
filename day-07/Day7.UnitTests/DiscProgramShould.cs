using System;
using Xunit;
using Day7.Models;

namespace Day7.UnitTests
{
    public class DiscProgramShould
    {
        [Fact]
        public void HaveNameAndWeight()
        {
            DiscProgram a = new DiscProgram("a", 1);
            DiscProgram b = new DiscProgram("b");

            Assert.Equal("a", a.Name);
            Assert.Equal(1, a.Weight);
            Assert.Equal("b", b.Name);
            Assert.Equal(0, b.Weight);
        }

        [Fact]
        public void AllowComparison()
        {
            DiscProgram first = new DiscProgram("a");
            DiscProgram second = new DiscProgram("a");
            DiscProgram third = new DiscProgram("b");

            Assert.True(first.Equals(second));
            Assert.False(first.Equals(third));
        }

        [Fact]
        public void TrackTotalWeights()
        {
            DiscProgram a = new DiscProgram("a", 2);
            DiscProgram b = new DiscProgram("b", 2);
            DiscProgram c = new DiscProgram("c", 2);

            a.AddChild(b);
            b.AddChild(c);

            // The total weight of a disc should be its own weight plus
            // the weight of all of its children.
            Assert.Equal(2, c.TotalWeight);
            Assert.Equal(4, b.TotalWeight);
            Assert.Equal(6, a.TotalWeight);

            // Adding a new program at the top of the stack should result in
            // it inheriting the total weight of all of the discs under it.
            DiscProgram d = new DiscProgram("d", 4);
            d.AddChild(a);
            Assert.Equal(10, d.TotalWeight);

            // Adding a new program to the "bottom" should update every disc above it.
            DiscProgram e = new DiscProgram("e", 1);
            c.AddChild(e);

            Assert.Equal(3, c.TotalWeight);
            Assert.Equal(5, b.TotalWeight);
            Assert.Equal(7, a.TotalWeight);
            Assert.Equal(11, d.TotalWeight);

            // Adding a new disc somewhere in the middle should update any of the discs that
            // are above it in the tree and not change any others.
            DiscProgram f = new DiscProgram("f", 1);
            b.AddChild(f);

            // Unchanged
            Assert.Equal(3, c.TotalWeight);
            Assert.Equal(1, e.TotalWeight);

            // Changed
            Assert.Equal(6, b.TotalWeight);
            Assert.Equal(8, a.TotalWeight);
            Assert.Equal(12, d.TotalWeight);

            // Lastly, if we later update the weight of a disc, then the 
            // tower should update as required.
            f.SetWeight(3);

            Assert.Equal(8, b.TotalWeight);
            Assert.Equal(10, a.TotalWeight);
            Assert.Equal(14, d.TotalWeight);

        }
    }
}
