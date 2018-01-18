using System;
using Day13.Factories;
using Day13.Models;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText("Inputs/day-13.txt");
            Firewall f = FirewallFactory.CreateFromString(input);
            Packet p = new Packet();

            // Part one
            Console.WriteLine(p.GetTravelCost(f));

            // Part two
            Console.WriteLine(p.GetDelayForNoAlarms(f));
        }
    }
}
