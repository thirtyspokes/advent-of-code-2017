using System.Collections.Generic;
using System.Linq;

namespace Day4.Services
{
    public class PassphraseListChecker
    {
        private readonly IInputParser _parser;
        private readonly IEnumerable<IPassphraseAnalyzer> _analyzers;

        public PassphraseListChecker(IInputParser parser, IEnumerable<IPassphraseAnalyzer> analyzers)
        {
            _parser = parser;
            _analyzers = analyzers;
        }

        public int CountValidPassphrases(string input)
        {
            IEnumerable<string[]> phrases = _parser.ParseInput(input);
            return phrases.Where(x => _RunAnalyzers(x)).Count();
        }

        private bool _RunAnalyzers(string[] phrase)
        {
            foreach(var analyzer in _analyzers)
            {
                if (!analyzer.Analyze(phrase))
                {
                    return false;
                }
            }

            return true;
        }
    }
}