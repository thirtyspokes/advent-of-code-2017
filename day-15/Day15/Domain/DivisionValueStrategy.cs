namespace Day15.Domain
{
    public class DivisionValueStrategy : IValueStrategy
    {
        private readonly int _divisor;

        public DivisionValueStrategy(int divisor)
        {
            _divisor = divisor;
        }

        public bool CanUseValue(long value)
        {
            return value % _divisor == 0;
        }
    }
}