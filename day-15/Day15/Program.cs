using System;
using Day15.Models;
using Day15.Domain;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator a = new Generator(783, 16807, new SimpleValueStrategy());
            Generator b = new Generator(325, 48271, new SimpleValueStrategy());
            Judge j = new Judge(a, b, 40_000_000);

            // Part one
            Console.WriteLine(j.CountPairs());

            
            a = new Generator(783, 16807, new DivisionValueStrategy(4));
            b = new Generator(325, 48271, new DivisionValueStrategy(8));
            j = new Judge(a, b, 5_000_000);

            // Part two
            Console.WriteLine(j.CountPairs());
        }
    }
}
