using System;
using System.Collections.Generic;
using System.Linq;
using Day13.Models;

namespace Day13.Factories
{
    public class FirewallFactory
    {
        public FirewallFactory()
        {
        }

        public static Firewall CreateFromString(string input)
        {
            var layers = _getLayersFromString(input);
            return new Firewall(layers);
        }

        private static FirewallLayer[] _getLayersFromString(string input)
        {
            IEnumerable<string> lines = input.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, int> parsed = lines
                .Select(x => x.Trim().Split(": ", StringSplitOptions.RemoveEmptyEntries))
                .Select(pairs => (Int32.Parse(pairs[0]), Int32.Parse(pairs[1])))
                .ToDictionary(x => x.Item1, x => x.Item2);

            var lastIndex = parsed.Last().Key;
            List<FirewallLayer> layers = new List<FirewallLayer>();

            for (int i = 0; i < lastIndex + 1; i++)
            {
                FirewallLayer layer;

                if (parsed.ContainsKey(i))
                {
                    layer = new FirewallLayer(parsed[i], true);
                }
                else
                {
                    layer = new FirewallLayer(1, false);
                }

                layers.Add(layer);
            }

            return layers.ToArray();
        }
    }
}