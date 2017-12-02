using DayTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DayTwo.Services
{
    public class StringSpreadsheetInputParser : ISpreadsheetInputParser
    {
        public StringSpreadsheetInputParser()
        {

        }

        public Spreadsheet ParseInput(string input)
        {
            var lines = input.Split("\n")
                .Select(x => x.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(y => Int32.Parse(y)));
            IEnumerable<Row> rows = lines.Select(x => new Row(x));
            return new Spreadsheet(rows);
        }
    }
}