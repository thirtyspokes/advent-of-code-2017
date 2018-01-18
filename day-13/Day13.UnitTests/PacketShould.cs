using System;
using Xunit;
using Day13.Models;
using Day13.Factories;

namespace Day13.UnitTests
{
    public class PacketShould
    {
        [Fact]
        public void CalculateCostOfTraveling()
        {
            var input = @"0: 3
            1: 2
            4: 4
            6: 4";

            Firewall f = FirewallFactory.CreateFromString(input);
            Packet p = new Packet();

            Assert.Equal(24, p.GetTravelCost(f)); 
        }

        [Fact]
        public void CalculateDelayForNoAlarms()
        {
            var input = @"0: 3
            1: 2
            4: 4
            6: 4";

            Firewall f = FirewallFactory.CreateFromString(input);
            Packet p = new Packet();

            Assert.Equal(10, p.GetDelayForNoAlarms(f)); 
        }
    }   
}
