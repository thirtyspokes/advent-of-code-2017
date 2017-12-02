using Xunit;
using DayTwo.Models;

namespace DayTwo.UnitTests
{
    public class RowShould
    {
        [Fact]
        public void CalculateDifferenceCorrectly()
        {
            Row a = new Row(new int[]{5, 1, 9, 5});
            Row b = new Row(new int[]{7, 5, 3});
            Row c = new Row(new int[]{2, 4, 6, 8});

            Assert.Equal(8, a.Difference());
            Assert.Equal(4, b.Difference());
            Assert.Equal(6, c.Difference());
        }

        [Fact]
        public void CalculateDivisionCorrectly()
        {
            Row a = new Row(new int[]{5, 9, 2, 8});
            Row b = new Row(new int[]{9, 4, 7, 3});
            Row c = new Row(new int[]{3, 8, 6, 5});

            Assert.Equal(4, a.Dividend());
            Assert.Equal(3, b.Dividend());
            Assert.Equal(2, c.Dividend());
        }
    }
}