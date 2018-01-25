using System;
using Xunit;
using Day15.Models;
using Day15.Domain;

namespace Day15.UnitTests
{
    public class GeneratorShould
    {
        [Fact]
        public void GenerateValuesBasedOnSeed()
        {
            Generator first = new Generator(65, 16807, new SimpleValueStrategy());
            Assert.Equal(1092455, first.GenerateNext());
            Assert.Equal(1181022009, first.GenerateNext());
            Assert.Equal(245556042, first.GenerateNext());
            Assert.Equal(1744312007, first.GenerateNext());
            Assert.Equal(1352636452, first.GenerateNext());
            
            Generator second = new Generator(8921, 48271, new SimpleValueStrategy());
            Assert.Equal(430625591, second.GenerateNext());
            Assert.Equal(1233683848, second.GenerateNext());
            Assert.Equal(1431495498, second.GenerateNext());
            Assert.Equal(137874439, second.GenerateNext());
            Assert.Equal(285222916, second.GenerateNext());
        }

        [Fact]
        public void GenerateValuesWithDivisionStrategy()
        {
            Generator first = new Generator(65, 16807, new DivisionValueStrategy(4));
            Assert.Equal(1352636452, first.GenerateNext());
            Assert.Equal(1992081072, first.GenerateNext());
            Assert.Equal(530830436, first.GenerateNext());
            Assert.Equal(1980017072, first.GenerateNext());
            Assert.Equal(740335192, first.GenerateNext());

            Generator second = new Generator(8921, 48271, new DivisionValueStrategy(8));
            Assert.Equal(1233683848, second.GenerateNext());
            Assert.Equal(862516352, second.GenerateNext());
            Assert.Equal(1159784568, second.GenerateNext());
            Assert.Equal(1616057672, second.GenerateNext());
            Assert.Equal(412269392, second.GenerateNext());
        }
    }
}
