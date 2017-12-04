using System;
using Xunit;
using Day4.Services;

namespace Day4.UnitTests
{
    public class NoAnagramsAnalyzerShould
    {
        [Fact]
        public void VerifyThatThereAreNoAnagrams()
        {
            NoAnagramsAnalyzer analyzer = new NoAnagramsAnalyzer();

            Assert.Equal(true, analyzer.Analyze(new string[]{"abcde", "fghij"}));
            Assert.Equal(false, analyzer.Analyze(new string[]{"abcde", "xyz", "ecdab"}));
            Assert.Equal(true, analyzer.Analyze(new string[]{"a", "ab", "abc", "abd", "abf", "abj"}));
            Assert.Equal(true, analyzer.Analyze(new string[]{"iiii", "oiii", "ooii", "oooi", "oooo"}));
            Assert.Equal(false, analyzer.Analyze(new string[]{"oiii", "ioii", "iioi", "iiio"}));
        }
    }
}
