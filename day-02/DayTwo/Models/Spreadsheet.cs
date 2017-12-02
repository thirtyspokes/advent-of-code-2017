using System.Collections.Generic;
using System.Linq;

namespace DayTwo.Models
{
    public class Spreadsheet
    {
        private readonly IEnumerable<Row> _rows;

        public Spreadsheet(IEnumerable<Row> rows)
        {
            _rows = rows;
        }

        public int CalculateSubtractionChecksum()
        {
            return _rows.Aggregate(0, (sum, next) => sum + next.Difference());
        }

        public int CalculateDivisionChecksum()
        {
            return _rows.Aggregate(0, (sum, next) => sum + next.Dividend());
        }
    }
}