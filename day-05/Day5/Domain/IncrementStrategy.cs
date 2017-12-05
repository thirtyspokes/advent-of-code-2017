namespace Day5.Domain
{
    public class IncrementStrategy : IJumpStrategy
    {
        public IncrementStrategy()
        {
        }

        public int HandleJump(int value)
        {
            return value + 1;
        }
    }
}