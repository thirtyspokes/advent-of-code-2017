using System;
using DayOne.Services;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {

            // Part One
            FileInputParser parser = new FileInputParser();
            SimpleCaptchaSolver solver = new SimpleCaptchaSolver();
            CaptchaService service = new CaptchaService(parser, solver);

            Console.WriteLine(service.SolveCaptcha("inputs/part-one.txt"));

            // Part Two
            CircularCaptchaSolver circularSolver = new CircularCaptchaSolver();
            CaptchaService circularService = new CaptchaService(parser, circularSolver);

            Console.WriteLine(circularService.SolveCaptcha("inputs/part-one.txt"));
        }
    }
}
