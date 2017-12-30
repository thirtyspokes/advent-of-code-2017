using System;
using System.Linq;
using System.Collections.Generic;

namespace Day10
{
    public class KnotHash
    {
        public KnotHash()
        {
        }

        public string GenerateHash(string input, int rounds)
        {
            // Convert the input string to bytes.
            int[] bytes = this.GenerateInputSequence(input);

            // Perform 64 rounds of the knot hashing.
            var hashed = this.PerformHashRounds(bytes, rounds);

            // Partition the sparse hash into blocks of 16.
            var blocks = this.PartitionList(hashed, 16);

            // Turn it into a dense hash by XOR'ing each element of each block together.
            var denseHash = blocks.Select(x => this.XORBlock(x));

            // Turn the results into hex.
            var hex = denseHash.Select(x => String.Format("{0:x2}", x));

            return String.Join("", hex);
        }

        public List<List<int>> PartitionList(int[] input, int blockSize)
        {
            List<List<int>> results = new List<List<int>>();

            int currentRun = 0;
            List<int> block = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                block.Add(input[i]);
                currentRun++;

                if (currentRun >= blockSize)
                {
                    results.Add(block);
                    block = new List<int>();
                    currentRun = 0;
                }
            }

            return results;
        }

        public int XORBlock(IEnumerable<int> input)
        {
            return input.Aggregate((total, x) => total ^ x);
        }

        public int[] GenerateInputSequence(string input)
        {
            int[] standardSuffix = {17, 31, 73, 47, 23};
            return input.Trim().ToCharArray().Select(x => (int)x).Concat(standardSuffix).ToArray();
        }

        public int[] PerformHashRounds(int[] input, int numRounds = 64, int listSize = 256)
        {
            int[] list = _generateList(listSize);
            int position = 0;
            int skipSize = 0;

            for (int i = 0; i < numRounds; i++)
            {
                foreach (int len in input)
                {
                    this.ReverseSubsequence(list, position, len);
                    position = this._getLoopingIndex(listSize, position + 1, len + skipSize);
                    skipSize++;
                }
            }

            return list;
        }

        public void ReverseSubsequence(int[] list, int start, int length)
        {
            while (length > 1) 
            {
                // Swap this value with its counterpart at the end of the subsequence.
                var temp = list[start];
                var target = _getLoopingIndex(list.Length, start, length);

                list[start] = list[target];
                list[target] = temp;

                // Shrink the subsequence from both ends, so that we can swap the next
                // pair: i.e., we first swapped (0, len) and will now swap (1, len - 1), etc.
                start = _getLoopingIndex(list.Length, start + 1, 1);
                length = length - 2;
            }
        }

        private int _getLoopingIndex(int listLength, int start, int runLength)
        {
            int offset = start + (runLength - 1);

            if (offset >= listLength)
            {
                return offset % listLength;
            }

            return offset;
        }

        private int[] _generateList(int length)
        {
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = i;
            }

            return result;
        }
    }
}