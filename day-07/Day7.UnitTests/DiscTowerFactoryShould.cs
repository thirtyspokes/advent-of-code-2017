using System;
using Xunit;
using Day7.Factories;
using Day7.Services;
using Day7.Models;

namespace Day7.UnitTests
{
    public class DiscTowerFactoryShould
    {
        [Fact]
        public void CreateDiscTowersFromInput()
        {
            string input = @"pbga (66)
                             xhth (57)
                             ebii (61)
                             havc (66)
                             ktlj (57)
                             fwft (72) -> ktlj, cntj, xhth
                             qoyq (66)
                             padx (45) -> pbga, havc, qoyq
                             tknk (41) -> ugml, padx, fwft
                             jptl (61)
                             ugml (68) -> gyxo, ebii, jptl
                             gyxo (61)
                             cntj (57)";

            StringInputReader reader = new StringInputReader();
            DiscTowerFactory factory = new DiscTowerFactory(reader);
            DiscTower tower = factory.CreateFromInput(input);

            Assert.Equal("tknk", tower.GetRootDisc().Name);
        }
    }
}
