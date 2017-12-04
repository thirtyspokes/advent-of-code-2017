using System;
using System.Collections.Generic;
using Day4.Services;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one
            FileInputParser parser = new FileInputParser();
            IEnumerable<IPassphraseAnalyzer> partOneAnalyzer = new IPassphraseAnalyzer[]
            {
                new UniqueWordsAnalyzer()
            };
            PassphraseListChecker partOne = new PassphraseListChecker(parser, partOneAnalyzer);
            Console.WriteLine(partOne.CountValidPassphrases("inputs/day-4.txt"));         

            // Part two
            IEnumerable<IPassphraseAnalyzer> partTwoAnalyzers = new IPassphraseAnalyzer[]
            {
                new UniqueWordsAnalyzer(),
                new NoAnagramsAnalyzer()
            };
            PassphraseListChecker partTwo = new PassphraseListChecker(parser, partTwoAnalyzers);
            Console.WriteLine(partTwo.CountValidPassphrases("inputs/day-4.txt"));
        }
    }
}
