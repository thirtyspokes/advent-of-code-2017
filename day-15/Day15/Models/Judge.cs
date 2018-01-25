using System;
using System.Linq;

namespace Day15.Models
{
    public class Judge
    {
        private readonly Generator _first;
        private readonly Generator _second;
        private readonly int _sampleSize;

        public Judge(Generator first, Generator second, int sampleSize)
        {
            _first = first;
            _second = second;
            _sampleSize = sampleSize;
        }

        public int CountPairs()
        {
            int count = 0;

            for (int i = 0; i < _sampleSize; i++)
            {
                var a = Convert.ToString(_first.GenerateNext(), 2);
                var b = Convert.ToString(_second.GenerateNext(), 2);

                if (this._isMatchingPair(a, b))
                {
                    count++;
                }
            }

            return count;
        }

        private bool _isMatchingPair(string a, string b)
        {
            var aTail = a.Skip(Math.Max(0, a.Count() - 16));
            var bTail = b.Skip(Math.Max(0, b.Count() - 16));
            return aTail.SequenceEqual(bTail);
        }
    }
}