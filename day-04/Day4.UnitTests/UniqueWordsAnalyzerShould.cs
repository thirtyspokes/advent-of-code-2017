using System;
using Xunit;
using Day4.Services;

namespace Day4.UnitTests
{
    public class UniqueWordsAnalyzerShould
    {
        [Fact]
        public void VerifyAllWordsAreUnique()
        {
            UniqueWordsAnalyzer analyzer = new UniqueWordsAnalyzer();

            Assert.Equal(true, analyzer.Analyze(new string[]{"aa", "bb", "cc", "dd", "ee"}));
            Assert.Equal(false, analyzer.Analyze(new string[]{"aa", "bb", "cc", "dd", "aa"}));
            Assert.Equal(true, analyzer.Analyze(new string[]{"aa", "bb", "cc", "dd", "aaa"}));
        }
    }
}
