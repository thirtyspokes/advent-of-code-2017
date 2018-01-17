using System;
using System.Collections.Generic;
using System.Linq;
using Day12.Models;

namespace Day12
{
    public class PipeGroupFinder
    {
        private readonly string _input;
        private readonly Dictionary<int, Node> _groups;

        public PipeGroupFinder(string input)
        {
            _input = input;
            _groups = this._createGroupsFromString(input);
        }

        public int FindGroupMemberCount(int targetID)
        {
            Node target = this._groups[targetID];
            return this._findGroupMembers(target).Count();
        }

        public int FindNumberOfGroups()
        {
            List<HashSet<Node>> knownGroups = new List<HashSet<Node>>();
            int count = 0;

            foreach (KeyValuePair<int, Node> item in this._groups)
            {
                if (!this._isInKnownGroup(item.Value, knownGroups))
                {
                    count += 1;
                    knownGroups.Add(this._findGroupMembers(item.Value));             
                }
            }

            return count;
        }

        private HashSet<Node> _findGroupMembers(Node node)
        {
            HashSet<Node> seen = new HashSet<Node>();
            seen.Add(node);
            return this._enumerateGroup(node, seen);  
        }

        private bool _isInKnownGroup(Node node, List<HashSet<Node>> knownGroups)
        {
            return knownGroups.Any(x => x.Contains(node));
        }

        private HashSet<Node> _enumerateGroup(Node node, HashSet<Node> seen)
        {
            foreach (Node n in node.Connections)
            {
                if (!seen.Contains(n)) {
                    seen.Add(n);
                    seen.UnionWith(this._enumerateGroup(n, seen));
                }
            }

            return seen;
        }

        private Dictionary<int, Node> _createGroupsFromString(string input)
        {
            var lines = input.Trim().Split("\n", StringSplitOptions.RemoveEmptyEntries);
            return this._createGroups(lines);
        }

        private Dictionary<int, Node> _createGroups(IEnumerable<string> lines)
        {
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            foreach (string line in lines)
            {
                var parts = this._parseLine(line);

                if (!nodes.ContainsKey(parts.Item1))
                {
                    var node = new Node(parts.Item1);
                    nodes[parts.Item1] = node;
                }

                var currentNode = nodes[parts.Item1];

                foreach (int item in parts.Item2)
                {
                    if (!nodes.ContainsKey(item))
                    {
                        var connection = new Node(item);
                        nodes[item] = connection;
                    }

                    currentNode.Connect(nodes[item]);
                }
            }

            return nodes;
        }
        
        private (int, IEnumerable<int>) _parseLine(string line)
        {
            var halves = line.Split("<->", StringSplitOptions.RemoveEmptyEntries);

            var target = Int32.Parse(halves[0].Trim());
            var members = halves[1].Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Int32.Parse(x.Trim()));

            return (target, members);
        }
    }
}