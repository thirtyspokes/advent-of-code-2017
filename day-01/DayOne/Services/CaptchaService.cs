namespace DayOne.Services
{
    public class CaptchaService
    {
        private readonly IInputParser _parser;
        private readonly ICaptchaSolver _solver;

        public CaptchaService(IInputParser parser, ICaptchaSolver solver)
        {
            _parser = parser;
            _solver = solver;
        }

        public int SolveCaptcha(string input)
        {
            int[] digits = _parser.ParseInput(input);
            return _solver.Solve(digits);
        }
    }
}