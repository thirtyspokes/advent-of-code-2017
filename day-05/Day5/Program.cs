using System;
using Day5.Domain;
using Day5.Services;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInputParser parser = new FileInputParser();
            int[] inputs = parser.ParseFile("inputs/day-5.txt");

            // Part One
            OffsetJumper jumperOne = new OffsetJumper(inputs, new IncrementStrategy());
            var timer = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Part one: " + jumperOne.StepsToExit() + " in " + timer.ElapsedMilliseconds + "ms.");

            // Part Two
            OffsetJumper jumperTwo = new OffsetJumper(inputs, new BalancingStrategy());
            timer = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Part two: " + jumperTwo.StepsToExit() + " in " + timer.ElapsedMilliseconds + "ms.");
        }
    }
}
