namespace Day15.Domain
{
    public class SimpleValueStrategy : IValueStrategy
    {
        public SimpleValueStrategy()
        {
        }

        public bool CanUseValue(long value)
        {
            return true;
        }
    }
}