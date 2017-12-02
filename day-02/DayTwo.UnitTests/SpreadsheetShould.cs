using System.Collections.Generic;
using Xunit;
using DayTwo.Models;

namespace DayTwo.UnitTests
{
    public class SpreadsheetShould
    {
        [Fact]
        public void CalculateSubtractionChecksums()
        {
            IEnumerable<Row> rows = new[]
            {
                new Row(new int[]{5, 1, 9, 5}),
                new Row(new int[]{7, 5, 3}),
                new Row(new int[]{2, 4, 6, 8})
            };

            Spreadsheet sheet = new Spreadsheet(rows);
            Assert.Equal(18, sheet.CalculateSubtractionChecksum());

            IEnumerable<Row> zeroRows = new[]
            {
                new Row(new int[]{0, 0, 0, 0}),
                new Row(new int[]{0, 0, 0, 0}),
                new Row(new int[]{0, 0, 0, 0})
            };

            Spreadsheet zeroSheet = new Spreadsheet(zeroRows);
            Assert.Equal(0, zeroSheet.CalculateSubtractionChecksum());
        }

        [Fact]
        public void CalculateDividendChecksums()
        {
            IEnumerable<Row> rows = new[]
            {
                new Row(new int[]{5, 9, 2, 8}),
                new Row(new int[]{9, 4, 7, 3}),
                new Row(new int[]{3, 8, 6, 5})
            };

            Spreadsheet sheet = new Spreadsheet(rows);
            Assert.Equal(9, sheet.CalculateDivisionChecksum());
        }
    }
}