using System;
using System.Collections;
using System.Threading.Tasks;
using Xunit;
using DayOne.Services;

namespace DayOne.UnitTests
{
    public class SimpleCaptchaSolverShould
    {
        [Fact]
        public void SolveCaptchas()
        {
            SimpleCaptchaSolver solver = new SimpleCaptchaSolver();
            Assert.Equal(3, solver.Solve(new int[]{1, 1, 2, 2}));
            Assert.Equal(4, solver.Solve(new int[]{1, 1, 1, 1}));
            Assert.Equal(0, solver.Solve(new int[]{1, 2, 3, 4}));
            Assert.Equal(9, solver.Solve(new int[]{9, 1, 2, 1, 2, 1, 2, 9}));
        }
    }
}