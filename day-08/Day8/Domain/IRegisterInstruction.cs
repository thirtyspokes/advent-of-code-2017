namespace Day8.Domain
{
    public interface IRegisterInstruction
    {
        int Modify(int original, int amount, int target, int condition);
    }
}