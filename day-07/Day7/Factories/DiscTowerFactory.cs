using Day7.Services;
using Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7.Factories
{
    public class DiscTowerFactory
    {
        private readonly IInputReader _reader;

        public DiscTowerFactory(IInputReader reader)
        {
            _reader = reader;
        }

        public DiscTower CreateFromInput(string input)
        {
            DiscTower tower = new DiscTower();
            IEnumerable<string> lines = _reader.ReadInput(input);

            foreach (string line in lines)
            {
                var parsedDisc = _extractDisc(line);
                var disc = tower.GetDisc(parsedDisc.Name);

                if (disc != null)
                {
                    // If this disc is already in the tower, this means it is the child
                    // of some other disc, but now we know the weight of it.
                    disc.SetWeight(parsedDisc.Weight);
                }
                else 
                {
                    disc = parsedDisc;

                    // If this disc isn't in the tower already, we'll want to add it.
                    tower.AddDisc(parsedDisc);
                }

                // If there are children for this disc, we will want to set up all the right
                // relationships.
                if (_hasChildren(line))
                {
                    var parsedChildren = _extractChildren(line);

                    foreach (DiscProgram child in parsedChildren)
                    {
                        var childDisc = tower.GetDisc(child.Name);

                        if (childDisc != null)
                        {
                            disc.AddChild(childDisc);
                        }
                        else
                        {
                            tower.AddDisc(child);
                            disc.AddChild(child);
                        }
                    }
                }
            }

            return tower;
        }

        private DiscProgram _extractDisc(string line)
        {
            var split = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var weight = split[1].Substring(1, split[1].Length - 2);

            return new DiscProgram(split[0].Trim(), Int32.Parse(weight));
        }

        private bool _hasChildren(string line)
        {
            return line.IndexOf("->") != -1;
        }

        private IEnumerable<DiscProgram> _extractChildren(string line)
        {
            var split = line.Split("->", StringSplitOptions.RemoveEmptyEntries);
            var children = split[1].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => new DiscProgram(x.Trim()));
            return children;
        }
    }
}