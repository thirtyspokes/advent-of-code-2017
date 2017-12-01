using System;
using System.Collections;
using System.Threading.Tasks;
using Xunit;
using DayOne.Services;

namespace DayOne.UnitTests
{
    public class CaptchaSolverShould
    {
        [Fact]
        public void SolveCaptchas()
        {
            CircularCaptchaSolver solver = new CircularCaptchaSolver();
            Assert.Equal(6, solver.Solve(new int[]{1, 2, 1, 2}));
            Assert.Equal(0, solver.Solve(new int[]{1, 2, 2, 1}));
            Assert.Equal(4, solver.Solve(new int[]{1, 2, 3, 4, 2, 5}));
            Assert.Equal(12, solver.Solve(new int[]{1, 2, 3, 1, 2, 3}));
            Assert.Equal(4, solver.Solve(new int[]{1, 2, 1, 3, 1, 4, 1, 5}));
        }
    }
}