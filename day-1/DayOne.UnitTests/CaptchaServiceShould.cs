using System;
using System.Collections;
using System.Threading.Tasks;
using Xunit;
using DayOne;
using DayOne.Services;

namespace DayOne.UnitTests
{
    public class CaptchaServiceShould
    {
        [Fact]
        public void SolveCaptchasWithSimpleSolver()
        {
            SimpleCaptchaSolver solver = new SimpleCaptchaSolver();
            StringInputParser parser = new StringInputParser();
            CaptchaService service = new CaptchaService(parser, solver);

            Assert.Equal(3, service.SolveCaptcha("1122"));
            Assert.Equal(4, service.SolveCaptcha("1111"));
            Assert.Equal(0, service.SolveCaptcha("1234"));
            Assert.Equal(9, service.SolveCaptcha("91212129"));
        }

        [Fact]
        public void SolveCaptchasWithCircularSolver()
        {
            CircularCaptchaSolver solver = new CircularCaptchaSolver();
            StringInputParser parser = new StringInputParser();
            CaptchaService service = new CaptchaService(parser, solver);

            Assert.Equal(6, service.SolveCaptcha("1212"));
            Assert.Equal(0, service.SolveCaptcha("1221"));
            Assert.Equal(4, service.SolveCaptcha("123425"));
            Assert.Equal(12, service.SolveCaptcha("123123"));
            Assert.Equal(4, service.SolveCaptcha("12131415"));

        }
    }
}