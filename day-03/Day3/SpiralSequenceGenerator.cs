using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public class SpiralSequenceGenerator
    {
        public SpiralSequenceGenerator()
        {
        }

        public int GetValueAfter(int target)
        {
            Dictionary<(int, int), int> seen = new Dictionary<(int, int), int>();
            seen.Add((0, 0), 1);

            var start = (0, 1);
            while (true)
            {
                // Calculate the value of this square - the sum of all of
                // the surrounding squares that have a value.
                var total = GetSurroundingSquares(start)
                    .Where(pair => seen.ContainsKey(pair))
                    .Select(pair => seen[pair])
                    .Aggregate(0, (sum, val) => sum + val);

                if (total > target)
                {
                    return total;
                }

                // Set the value of this square, if we didn't find what we wanted.
                seen.Add(start, total);

                // Figure out where to move for the next loop.
                start = GetNextMove(start, seen);
            }
        }

        private IEnumerable<(int, int)> GetSurroundingSquares((int, int) square)
        {
            return new (int, int)[]
            {
                    (square.Item1 + 1, square.Item2 + 1),
                    (square.Item1 + 1, square.Item2),
                    (square.Item1, square.Item2 + 1),
                    (square.Item1 - 1, square.Item2),
                    (square.Item1, square.Item2 - 1),
                    (square.Item1 - 1, square.Item2 - 1),
                    (square.Item1 - 1, square.Item2 + 1),
                    (square.Item1 + 1, square.Item2 - 1)
            };
        }

        private (int, int) GetNextMove((int, int) current, Dictionary<(int, int), int> spiral)
        {
                var hasAbove = spiral.ContainsKey((current.Item1, current.Item2 + 1));
                var hasBelow = spiral.ContainsKey((current.Item1, current.Item2 - 1));
                var hasLeft  = spiral.ContainsKey((current.Item1 -1, current.Item2));
                var hasRight = spiral.ContainsKey((current.Item1 + 1, current.Item2));

                if (hasLeft && !hasRight && !hasAbove && !hasBelow)
                {
                    // Go up.
                    return (current.Item1, current.Item2 + 1);
                }
                else if (!hasLeft && !hasRight && !hasAbove && hasBelow)
                {       
                    // Go left.
                    return (current.Item1 - 1, current.Item2);
                }
                else if (!hasLeft && hasRight && !hasAbove && hasBelow)
                {
                    // Go left.
                    return (current.Item1 - 1, current.Item2);
                }
                else if (!hasLeft && hasRight && !hasAbove && !hasBelow)
                {
                    // Go down.
                    return (current.Item1, current.Item2 - 1);
                }
                else if (!hasLeft && hasRight && hasAbove && !hasBelow)
                {
                    // Go down.
                    return (current.Item1, current.Item2 - 1);
                }
                else if (!hasLeft&& !hasRight && hasAbove && !hasBelow )
                {
                    // Go right.
                    return (current.Item1 + 1, current.Item2);
                }
                else if (hasLeft && !hasRight && hasAbove && !hasBelow)
                {
                    // Go right.
                    return (current.Item1 + 1, current.Item2);
                }
                else if (hasLeft && !hasRight && hasAbove && !hasBelow)
                {
                    // Go right.
                    return (current.Item1 + 1, current.Item2);
                }
                else
                {
                    // Go up.
                    return (current.Item1, current.Item2 + 1);
                }
        }
    }
}