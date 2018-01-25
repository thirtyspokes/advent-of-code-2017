using System;
using Xunit;
using Day16.Domain;

namespace Day16.UnitTests.Domain
{
    public class SpinShould
    {
        [Fact]
        public void RearrangePrograms()
        {
            var spin = new Spin(3);
            var input = new char[]{'a', 'b', 'c', 'd', 'e'};
            Assert.Equal(new char[]{'c', 'd', 'e', 'a', 'b'}, spin.ApplyStep(input));

            spin = new Spin(1);
            input = new char[]{'a', 'b', 'c', 'd', 'e'};
            Assert.Equal(new char[]{'e', 'a', 'b', 'c', 'd'}, spin.ApplyStep(input));
        }

        [Fact]
        public void CreateFromStrings()
        {
            var spin = Spin.CreateFromString("s1");
            Assert.Equal(1, spin.Amount);

            spin = Spin.CreateFromString("s34233");
            Assert.Equal(34233, spin.Amount);
        }
    }
}
