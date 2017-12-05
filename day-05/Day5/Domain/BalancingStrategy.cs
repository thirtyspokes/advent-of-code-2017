namespace Day5.Domain
{
    public class BalancingStrategy : IJumpStrategy
    {
        public BalancingStrategy()
        {
        }

        public int HandleJump(int value)
        {
            if (value >= 3)
            {
                return value - 1;
            } 
            else 
            {
                return value + 1;
            }
        }
    }
}