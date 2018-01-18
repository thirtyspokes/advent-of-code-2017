using System;
using Xunit;
using Day13.Models;
using Day13.Factories;

namespace Day13.UnitTests
{
    public class FirewalFactoryShould
    {
        [Fact]
        public void CreateFirewallsFromStrings()
        {
            var input = @"0: 3
            1: 2
            4: 4
            6: 4";

            Firewall f = FirewallFactory.CreateFromString(input);

            Assert.Equal(7, f.Depth());
            Assert.Equal(3, f.RangeAtDepth(0));
            Assert.Equal(2, f.RangeAtDepth(1));
            Assert.Equal(1, f.RangeAtDepth(2));
            Assert.Equal(1, f.RangeAtDepth(3));
            Assert.Equal(4, f.RangeAtDepth(4));
            Assert.Equal(1, f.RangeAtDepth(5));
            Assert.Equal(4, f.RangeAtDepth(6));
        }
    }   
}
