using System;
using System.Linq;
using System.Collections.Generic;
using DayTwo.Models;

namespace DayTwo.Services
{
    public class FileSpreadsheetInputParser : ISpreadsheetInputParser
    {
        public FileSpreadsheetInputParser()
        {

        }

        public Spreadsheet ParseInput(string path)
        {
            var raw = System.IO.File.ReadAllText(path).Trim();
            var lines = raw.Split("\n")
                .Select(x => x.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(y => Int32.Parse(y)));
            IEnumerable<Row> rows = lines.Select(x => new Row(x));
            return new Spreadsheet(rows);
        }
    }
}