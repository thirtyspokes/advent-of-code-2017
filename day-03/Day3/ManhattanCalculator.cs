using System;
using System.Linq;

namespace Day3
{
    public class ManhattanCalculator
    {
        private readonly int _squareNumber;

        private readonly int _radius;

        public ManhattanCalculator(int squareNumber)
        {
            _squareNumber = squareNumber;
            _radius = CalculateRadius();
        }

        public int ManhattanDistance()
        {
            if (_squareNumber == 1)
            {
                return 0;
            }

            // Each of the (0, x) or (x,0) points on the grid has a shortest path to the
            // center - a straight line.  So to calculate the shortest manhattan distance, first
            // calculate the distance from the target point to the nearest of the four "corners", and
            // add that to the radius.
            var potentials = new int[]
            {
                Math.Abs(_squareNumber - TopSquare()),
                Math.Abs(_squareNumber - RightSquare()),
                Math.Abs(_squareNumber - LeftSquare()),
                Math.Abs(_squareNumber - BottomSquare()) 
            };

            return potentials.Min() + _radius;
        }

        private int CalculateRadius()
        {
            var n = 1;
            var total = 1;

            if (_squareNumber == 1)
            {
                return 0;
            }

            while (total <= _squareNumber)
            {
                total += 8 * n;
                n += 1;
            }

            return n - 1;
        }

        private int TopSquare()
        {
            if (_radius == 0)
            {
                return 1;
            }
            else if (_radius == 1)
            {
                return 4;
            }
            else
            {
                var total = 4;
                var add = 3;
                var count = 2;

                while (true)
                {
                    add = add + 8;
                    total = total + add;
                    
                    if (count == _radius)
                    {
                        break;
                    }

                    count++;
                }

                return total;
            }
        }

        private int RightSquare()
        {
            return TopSquare() - (_radius * 2);
        }
        
        private int LeftSquare()
        {
            return TopSquare() + (_radius * 2);
        }

        private int BottomSquare()
        {
            return LeftSquare() + (_radius * 2);
        }      
    }
}