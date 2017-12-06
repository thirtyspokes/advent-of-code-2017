using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class BlockMemoryBank
    {
        private IEnumerable<int> _originalBlocks;

        public BlockMemoryBank(IEnumerable<int> initialBlocks)
        {
            _originalBlocks = initialBlocks;
        }

        public int CountReallocationLoopLength()
        {
            // Add the starting configuration to the seen blocks.
            var _seen = new Dictionary<string, int>();
            _seen.Add(string.Join(",", _originalBlocks), 0);

            int count = 0;
            var blocks = _originalBlocks.ToArray();

            while (true)
            {
                Reallocate(blocks);
                count += 1;

                // Determine if we've seen this before.
                var finalValue = string.Join(",", blocks);
                if (_seen.ContainsKey(finalValue))
                {
                    return count - _seen[finalValue];
                }

                // If we haven't seen it, add this to the list and move on.
                _seen.Add(finalValue, count);            
            }
        }

        public int CountReallocationCycles()
        {
            // Add the starting configuration to the seen blocks.
            var _seen = new Dictionary<string, int>();
            _seen.Add(string.Join(",", _originalBlocks), 0);
            int count = 0;
            var blocks = _originalBlocks.ToArray();

            while (true)
            {
                Reallocate(blocks);
                count = count + 1;

                // Determine if we've seen this before.
                var finalValue = string.Join(",", blocks);
                if (_seen.ContainsKey(finalValue))
                {
                    return count;
                }

                // If we haven't seen it, add this to the list and move on.
                _seen.Add(finalValue, count);            
            }
        }

        private void Reallocate(int[] blocks)
        {
            // Determine the next-highest value in the array.
            var nextConfiguration = blocks;
            var max = MaxIndex(nextConfiguration);
            var amount = nextConfiguration[max];
            nextConfiguration[max] = 0;

            // Redistribute the current block's value around the whole array.
            var startIndex = (max + 1) % nextConfiguration.Length;
            while (amount > 0)
            {
                nextConfiguration[startIndex] += 1;
                startIndex = (startIndex + 1) % nextConfiguration.Length;
                amount --;
            }
        }

        private int MaxIndex(IEnumerable<int> blocks)
        {
            var asArray = blocks.ToArray();
            int maxIndex = 0;
            int currentMax = asArray[0];

            for (int i = 0; i < asArray.Length; i++)
            {
                if (asArray[i] > currentMax)
                {
                    maxIndex = i;
                    currentMax = asArray[i];
                }
            }

            return maxIndex;
        }
    }
}