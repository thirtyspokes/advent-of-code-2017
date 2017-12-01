using System;

namespace DayOne.Services
{
    public class CircularCaptchaSolver : ICaptchaSolver
    {
        public CircularCaptchaSolver()
        {

        }

        public int Solve(int[] digits)
        {
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {   
                var compare = _GetIndexToCompare(i, digits.Length);
                if (digits[i] == digits[compare])
                {
                    sum += digits[i];
                }
            }

            return sum;
        }

        private int _GetIndexToCompare(int current, int length)
        {
            var ahead = current + (length / 2);

            if (ahead >= length) 
            {
                return ahead - length;
            }
            else {
                return ahead;
            }
        }
    }
}