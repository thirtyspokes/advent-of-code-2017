using System;
using Day7.Services;
using Day7.Factories;
using Day7.Models;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInputReader reader = new FileInputReader();
            DiscTowerFactory factory = new DiscTowerFactory(reader);
            DiscTower tower = factory.CreateFromInput("Inputs/day-7.txt");

            // Part one
            Console.WriteLine(tower.GetRootDisc().Name);

            // Part two
            Console.WriteLine(tower.FindBalancingProgramWeight());
        }
    }
}
