using System.Collections.Generic;

namespace DayOne.Services
{
    public class SimpleCaptchaSolver : ICaptchaSolver
    {
        public SimpleCaptchaSolver()
        {
        }

        public int Solve(int[] digits)
        {
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (i == digits.Length - 1)
                {
                    if (digits[i] == digits[0])
                    {
                        sum += digits[i];
                    }
                }
                else
                {
                    if (digits[i] == digits [i + 1])
                    {
                        sum += digits[i];
                    }
                }
            }

            return sum;
        }
    }
}