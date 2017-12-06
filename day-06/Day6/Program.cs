using System;
using Day6.Services;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInputParser parser = new FileInputParser();
            BlockMemoryBank bank = new BlockMemoryBank(parser.ParseInput("inputs/day-6.txt"));

            // Part one
            Console.WriteLine(bank.CountReallocationCycles());

            // Part two
            Console.WriteLine(bank.CountReallocationLoopLength());
        }
    }
}
