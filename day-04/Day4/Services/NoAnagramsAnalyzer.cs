using System;
using System.Linq;
using System.Collections.Generic;

namespace Day4.Services
{
    public class NoAnagramsAnalyzer : IPassphraseAnalyzer
    {
        public NoAnagramsAnalyzer()
        {}

        public bool Analyze(string[] passphrase)
        {
            IEnumerable<string> sortedWords = passphrase.Select(x => _SortedString(x));
            return new HashSet<string>(sortedWords).Count == passphrase.Length;

        }

        private string _SortedString(string original)
        {
            var sorted = original.ToCharArray();
            Array.Sort(sorted);
            return new String(sorted);
        }
    }
}