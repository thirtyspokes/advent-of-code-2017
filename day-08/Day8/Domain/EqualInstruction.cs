namespace Day8.Domain
{
    public class EqualInstruction : IRegisterInstruction
    {
        private readonly bool _isAddition;

        public EqualInstruction(bool addition)
        {
            _isAddition = addition;
        }

        public int Modify(int original, int amount, int target, int condition)
        {
            if (target == condition)
            {
                if (_isAddition)
                {
                    return original + amount;
                }
                else
                {
                    return original - amount;
                }
            }

            return original;
        }
    }
}