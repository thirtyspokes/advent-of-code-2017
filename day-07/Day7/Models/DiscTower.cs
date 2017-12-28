using System.Collections.Generic;
using System.Linq;
using System;

namespace Day7.Models
{
    public class DiscTower
    {
        private Dictionary<string, DiscProgram> _tower;

        public DiscTower()
        {
            _tower = new Dictionary<string, DiscProgram>();
        }

        public void AddDisc(DiscProgram program)
        {
            _tower.Add(program.Name, program);
        }

        public DiscProgram GetDisc(string name)
        {
            if (_tower.ContainsKey(name))
            {
                return _tower[name];
            }
            else
            {
                return null;
            }
        }

        public DiscProgram GetRootDisc()
        {
            DiscProgram disc = _tower.First().Value;

            while (disc.Parent != null)
            {
                disc = disc.Parent;
            }

            return disc;
        }

        public int FindBalancingProgramWeight()
        {
            var disc = this.GetRootDisc();
            
            while (disc.Children.Count > 0)
            {
                var groups = disc.Children.GroupBy(x => x.TotalWeight);
                var hasOutlier = false;
                var outlier = disc.Children.First();

                foreach (var group in groups)
                {
                    if (group.Count() == 1)
                    {
                        hasOutlier = true;
                        outlier = group.First();
                    }
                }

                if (!hasOutlier)
                {
                    return disc.Weight - _findAmountOfUnbalance();
                }

                disc = outlier;
            }

            return 0;
        }

        private int _findAmountOfUnbalance()
        {
            var disc = this.GetRootDisc();
            var groups = disc.Children.GroupBy(x => x.TotalWeight);
            var outlier = 0;
            var rest = 0;

            foreach (var group in groups)
            {
                if (group.Count() == 1)
                {
                    outlier = group.First().TotalWeight;
                }
                else
                {
                    rest = group.First().TotalWeight;
                }
            }

            return outlier - rest;
        }
    }
}