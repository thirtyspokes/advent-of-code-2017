using System.Collections.Generic;
using System.Linq;

namespace DayTwo.Models
{
    public class Row
    {
        private readonly IEnumerable<int> _cells;

        public Row(IEnumerable<int> cells)
        {
            _cells = cells;
        }

        public int Difference()
        {
            return _cells.Max() - _cells.Min();
        }

        public int Dividend()
        {
            var cells = _cells.ToArray();

            for (int i = 0; i < cells.Length - 1; i++)
            {
                var x = cells[i];

                for (int j = i + 1; j < cells.Length; j++)
                {
                    var y = cells[j];

                    if (x % y == 0)
                    {
                        return x / y;
                    }
                    else if (y % x == 0)
                    {
                        return y / x;
                    }
                }
            }
           
            return 0;
        }
    }
}