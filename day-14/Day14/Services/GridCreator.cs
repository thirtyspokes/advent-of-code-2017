using Day10;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day14.Services
{
    public class GridCreator
    {
        private readonly KnotHash _hasher;

        private const int GRID_SIZE = 128;
        private const int KNOT_HASH_ROUNDS = 64;

        public GridCreator(KnotHash hasher)
        {
            _hasher = hasher;
        }

        public int[][] Generate(string input)
        {
            List<int[]> hashes = new List<int[]>();

            for (int i = 0; i < GRID_SIZE; i++)
            {
                var hashed = _hasher.GenerateHash(input + "-" + i, KNOT_HASH_ROUNDS);
                var row = hashed.Select(x => this._toBin(x.ToString()));
                hashes.Add(row.SelectMany(x => x).Select(x => int.Parse(x.ToString())).ToArray());
            }

            return hashes.ToArray();
        }

        private string _toBin(string digit)
        {
            return Convert.ToString(Convert.ToInt32(digit, 16), 2).PadLeft(4, '0');
        }
    }
}