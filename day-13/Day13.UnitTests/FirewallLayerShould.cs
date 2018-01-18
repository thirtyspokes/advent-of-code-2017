using System;
using Xunit;
using Day13.Models;

namespace Day13.UnitTests
{
    public class FirewallLayerShould
    {
        [Fact]
        public void MoveScannerCorrectly()
        {
            FirewallLayer layer = new FirewallLayer(3, true);
            
            Assert.False(layer.SafeAtTime(0));
            Assert.True(layer.SafeAtTime(1));
            Assert.False(layer.SafeAtTime(4));
        }

        [Fact]
        public void MoveScannerWhenLengthIsOne()
        {
            FirewallLayer layer = new FirewallLayer(1, true);
            Assert.False(layer.SafeAtTime(0));
            Assert.False(layer.SafeAtTime(1));
            Assert.False(layer.SafeAtTime(2));
        }

        [Fact]
        public void MoveScannerWhenLengthIsTwo()
        {
            FirewallLayer layer = new FirewallLayer(2, true);
            Assert.False(layer.SafeAtTime(0));
            Assert.True(layer.SafeAtTime(1));
            Assert.False(layer.SafeAtTime(2));
        }

        [Fact]
        public void CaclculateSafetyAtGivenTime()
        {
            FirewallLayer layer = new FirewallLayer(4, true);
            Assert.False(layer.SafeAtTime(0));
            Assert.True(layer.SafeAtTime(1));
            Assert.True(layer.SafeAtTime(2));
            Assert.True(layer.SafeAtTime(3));
            Assert.True(layer.SafeAtTime(4));
            Assert.True(layer.SafeAtTime(5));
            Assert.False(layer.SafeAtTime(6));
            Assert.True(layer.SafeAtTime(7));

            FirewallLayer layerWithoutScanner = new FirewallLayer(2, false);
            Assert.True(layerWithoutScanner.SafeAtTime(0));
            Assert.True(layerWithoutScanner.SafeAtTime(100));
        }
    }   
}
