using System;
using Xunit;
using Day16.Domain;

namespace Day16.UnitTests.Domain
{
    public class PartnerShould
    {
        [Fact]
        public void RearrangePrograms()
        {
            var partner = new Partner('e', 'b');
            var input = new char[]{'e', 'a', 'b', 'd', 'c'};
            Assert.Equal(new char[]{'b', 'a', 'e', 'd', 'c'}, partner.ApplyStep(input));
        }

        [Fact]
        public void CreateFromStrings()
        {
            var partner = Partner.CreateFromString("pA/B");
            Assert.Equal('A', partner.First);
            Assert.Equal('B', partner.Second);
        }
    }
}
