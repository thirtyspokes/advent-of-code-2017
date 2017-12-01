namespace DayOne.Services
{
    public interface ICaptchaSolver
    {
        int Solve(int[] digits);
    }
}