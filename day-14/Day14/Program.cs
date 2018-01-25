using System;
using System.Linq;
using System.Collections.Generic;
using Day14.Services;
using Day10;

namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            KnotHash kh = new KnotHash();
            GridCreator d = new GridCreator(kh);
            Defragmentor f = new Defragmentor();
            var square = d.Generate("nbysizxe");

            // Part one
            Console.WriteLine(f.GetUsedSpace(square));

            // Part two
            Console.WriteLine(f.CountUsedGroups(square));
        }
    }
}
