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
            IEnumerable<Row> rows = input.Split("\n")
                .Select(x => x.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(y => Int32.Parse(y)))
                .Select(x => new Row(x));
            return new Spreadsheet(rows);
        }
    }
}