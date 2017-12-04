using System.Collections.Generic;

namespace Day4.Services
{
    public interface IPassphraseAnalyzer
    {
        bool Analyze(string[] passphrase);
    }
}