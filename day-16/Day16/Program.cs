using System;
using System.Collections.Generic;
using Day16.Services;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawInput = System.IO.File.ReadAllText("Inputs/day-16.txt").Trim();
            var startingPrograms = new char[]{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                                              'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p'};

            DanceStepParser p = new DanceStepParser();
            var steps = p.ParseSteps(rawInput);

            DanceExecutor e = new DanceExecutor(startingPrograms);
            var dance = e.Execute(steps);

            // Set up a dictionary to memoize the results of each call to
            // the dance executor.
            Dictionary<string, char[]> cache = new Dictionary<string, char[]>();
            cache.Add(String.Join("", startingPrograms), dance);

            // Part one
            Console.WriteLine(String.Join("", dance));

            // Part two
            for (long i = 1; i < 1_000_000_000; i++)
            {
                var key = String.Join("", dance);

                if (cache.ContainsKey(key))
                {
                    dance = cache[key];
                }
                else
                {
                    e = new DanceExecutor(dance);
                    dance = e.Execute(steps);
                    cache.Add(key, dance);
                }
            }

            Console.WriteLine(String.Join("", dance));
        }
    }
}
