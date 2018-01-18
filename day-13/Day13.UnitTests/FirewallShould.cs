using System;
using Xunit;
using Day13.Models;
using Day13.Factories;

namespace Day13.UnitTests
{
    public class FirewallShould
    {
        [Fact]
        public void HandleTicksAndAlarms()
        {
            var input = @"0: 3
            1: 2
            4: 4";

            Firewall f = FirewallFactory.CreateFromString(input);
            
            // At time 0...
            Assert.True(f.AlarmWillBeTriggered(0, 0));
            Assert.True(f.AlarmWillBeTriggered(1, 0));
            Assert.False(f.AlarmWillBeTriggered(2, 0));
            Assert.False(f.AlarmWillBeTriggered(3, 0));
            Assert.True(f.AlarmWillBeTriggered(4, 0));

            // At time 2...
            Assert.False(f.AlarmWillBeTriggered(0, 2));
            Assert.True(f.AlarmWillBeTriggered(1, 2));
            Assert.False(f.AlarmWillBeTriggered(2, 2));
            Assert.False(f.AlarmWillBeTriggered(3, 2));
            Assert.False(f.AlarmWillBeTriggered(4, 2));   
        }
    }   
}
