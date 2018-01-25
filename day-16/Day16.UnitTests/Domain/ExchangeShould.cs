using System;
using Xunit;
using Day16.Domain;

namespace Day16.UnitTests.Domain
{
    public class ExchangeShould
    {
        [Fact]
        public void RearrangePrograms()
        {
            var exchange = new Exchange(3, 4);
            var input = new char[]{'e', 'a', 'b', 'c', 'd'};
            Assert.Equal(new char[]{'e', 'a', 'b', 'd', 'c'}, exchange.ApplyStep(input));
        }

        [Fact]
        public void CreateFromStrings()
        {
            var exchange = Exchange.CreateFromString("x1/2");
            Assert.Equal(1, exchange.First);
            Assert.Equal(2, exchange.Second);

            exchange = Exchange.CreateFromString("x101/2222");
            Assert.Equal(101, exchange.First);
            Assert.Equal(2222, exchange.Second);
        }
    }
}
