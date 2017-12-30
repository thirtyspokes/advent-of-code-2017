using System;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[]{70, 66, 255, 2, 48, 0, 54, 48, 80, 141, 244, 254, 160, 108, 1, 41};
            KnotHash kh = new KnotHash();

            // Part one
            Console.WriteLine(kh.CalculateSingleHashRound(256, input));

            // Part two
            Console.WriteLine(kh.GenerateHash("70,66,255,2,48,0,54,48,80,141,244,254,160,108,1,41", 64));
        }
    }
}
