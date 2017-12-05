using Day5.Domain;

namespace Day5
{
    public class OffsetJumper
    {
        private readonly int[] _offsets;

        private readonly IJumpStrategy _strategy;

        public OffsetJumper(int[] offsets, IJumpStrategy strategy)
        {
            _offsets = offsets;
            _strategy = strategy;
        }

        public int StepsToExit()
        {
            int[] offsets = (int[]) _offsets.Clone();
            int stepsTaken = 0;
            int position = 0;

            while (true)
            {
                // Determine where our next move will be.
                var nextPosition = position + offsets[position];

                // Handle the current offset's value.
                offsets[position] = _strategy.HandleJump(offsets[position]);

                // Increment the number of steps we have taken.
                stepsTaken++;

                // Determine if we are about to leave the maze.
                if (nextPosition >= offsets.Length || nextPosition < 0)
                {
                    return stepsTaken;
                }

                // Move to the next spot.
                position = nextPosition;
            }
        }
    }
}