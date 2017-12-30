using System;
using Day11.Services;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
                I used the following extremely well-written guide by Amit Patel (Red Blob Games)
                to understand how a hexogonal grid can be represented and how one traverses it:

                https://www.redblobgames.com/grids/hexagons

                It's one of the most nicely-presented resources on game development that I've
                ever seen!
            */

            FileInputReader reader = new FileInputReader();
            HexWalker walker = new HexWalker(reader);

            // Part one
            Console.WriteLine(walker.ShortestDistanceFromStart("Inputs/day-11.txt"));

            // Part two
            Console.WriteLine(walker.FarthestDistanceFromStart("Inputs/day-11.txt"));
        }
    }
}
