using System;
using System.Linq;
using System.Collections.Generic;

namespace Day4.Services
{
    public class UniqueWordsAnalyzer : IPassphraseAnalyzer
    {
        public UniqueWordsAnalyzer()
        {}

        public bool Analyze(string[] passphrase)
        {
            HashSet<string> asSet = new HashSet<string>(passphrase);
            return asSet.Count == passphrase.Count();
        }
    }
}