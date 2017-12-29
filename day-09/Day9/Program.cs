using System;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = System.IO.File.ReadAllText("Inputs/day-9.txt").Trim();
            StreamProcessor p = new StreamProcessor();

            // Part one
            Console.WriteLine(p.ProcessStreamScore(input));

            // Part two
            Console.WriteLine(p.ProcessGarbageLength(input));
        }
    }
}
