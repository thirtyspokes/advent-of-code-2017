using System.Linq;
using DayTwo.Models;
using DayTwo.Services;
using Xunit;

namespace DayTwo.UnitTests
{
    public class StringSpreadsheetInputParserShould
    {
        [Fact]
        public void CreateSpreadsheetsFromStrings()
        {
            StringSpreadsheetInputParser parser = new StringSpreadsheetInputParser();
            Spreadsheet parsed = parser.ParseInput("5 1 9 5\n7 5 3\n2 4 6 8");
            Spreadsheet emptyParsed = parser.ParseInput("1 1 1 1\n 1 1 1     1\n1 1 1 1 \n 1 1 1 1");

            Assert.Equal(18, parsed.CalculateSubtractionChecksum());
            Assert.Equal(0, emptyParsed.CalculateSubtractionChecksum());
        }
    }
}