using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one
            ManhattanCalculator calc = new ManhattanCalculator(325489);
            Console.WriteLine(calc.ManhattanDistance());

            // Part two
            SpiralSequenceGenerator generator = new SpiralSequenceGenerator();
            Console.WriteLine(generator.GetValueAfter(325489));
        }
    }
}
