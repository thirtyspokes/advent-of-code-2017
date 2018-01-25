using Day15.Domain;

namespace Day15.Models
{
    public class Generator
    {
        private readonly long _factor;
        private long _previousValue;
        private const long DIVISOR = 2147483647;
        private readonly IValueStrategy _strategy;

        public Generator(long startValue, long factor, IValueStrategy strategy)
        {
            _factor = factor;
            _previousValue = startValue;
            _strategy = strategy;
        }

        public long GenerateNext()
        {
            long newValue = (this._previousValue * this._factor) % DIVISOR;
            this._previousValue = newValue;

            while (!_strategy.CanUseValue(newValue))
            {
                newValue = (this._previousValue * this._factor) % DIVISOR;
                this._previousValue = newValue;
            }
            
            return newValue;
        }
    }
}