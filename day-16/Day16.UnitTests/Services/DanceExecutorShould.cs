using System;
using Xunit;
using Day16.Services;

namespace Day16.UnitTests.Services
{
    public class SpinShould
    {
        [Fact]
        public void ExecuteDanceSteps()
        {
            DanceStepParser p = new DanceStepParser();
            var steps = p.ParseSteps("s1,x3/4,pe/b");
            DanceExecutor e = new DanceExecutor(new char[]{'a', 'b', 'c', 'd', 'e'});

            Assert.Equal(new char[]{'b', 'a', 'e', 'd', 'c'}, e.Execute(steps));
        }

    }
}
