using System;
using System.Collections.Generic;
using Xunit;
using Day4.Services;

namespace Day4.UnitTests
{
    public class PassphraseListCheckerShould
    {
        [Fact]
        public void CountValidPassphrasesFromList()
        {
            StringInputParser parser = new StringInputParser();
            IEnumerable<IPassphraseAnalyzer> analyzers = new IPassphraseAnalyzer[]
            {
                new UniqueWordsAnalyzer()
            };

            PassphraseListChecker checker = new PassphraseListChecker(parser, analyzers);

            var input = "aa bb cc dd ee\naa bb cc dd aa\naa bb cc dd aaa";
            Assert.Equal(2, checker.CountValidPassphrases(input));
        }

        [Fact]
        public void RunMultipleAnalyzers()
        {
            StringInputParser parser = new StringInputParser();
            IEnumerable<IPassphraseAnalyzer> analyzers = new IPassphraseAnalyzer[]
            {
                new UniqueWordsAnalyzer(),
                new NoAnagramsAnalyzer()
            };

            PassphraseListChecker checker = new PassphraseListChecker(parser, analyzers);
            var input = "abcde fghij\naa bb cc dd aa\noiii ioii iioi iiio";
            Assert.Equal(1, checker.CountValidPassphrases(input));
        }
    }
}