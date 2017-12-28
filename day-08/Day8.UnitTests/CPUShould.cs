using System;
using Xunit;
using Day8.Models;

namespace Day8.UnitTests
{
    public class CPUShould
    {
        [Fact]
        public void StoreValues()
        {
            CPU cpu = new CPU();
            cpu.SetRegisterValue("a", 1);

            Assert.Equal(1, cpu.GetRegisterValue("a"));
        }

        [Fact]
        public void InitializeRegistersAtZero()
        {
            CPU cpu = new CPU();

            Assert.Equal(0, cpu.GetRegisterValue("a"));
        }

        [Fact]
        public void DeterminesTheLargestRegisterValues()
        {
            CPU cpu = new CPU();
            cpu.SetRegisterValue("a", 1);
            cpu.SetRegisterValue("b", 1000);
            cpu.SetRegisterValue("c", 3);
            cpu.SetRegisterValue("b", 1);

            Assert.Equal(3, cpu.GetCurrentLargestRegisterValue());
            Assert.Equal(1000, cpu.GetHistoricalLargestRegisterValue());
        }
    }
}
