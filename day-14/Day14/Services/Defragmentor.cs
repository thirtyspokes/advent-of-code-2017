using Day10;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day14.Services
{
    public class Defragmentor
    {
        public Defragmentor()
        {
        }

        public int GetUsedSpace(int[][] grid)
        {
            int count = 0;

            foreach (var row in grid)
            {
                count += row.Where(x => x == 1).Count();
            }

            return count;
        }

        public int CountUsedGroups(int[][] grid)
        {
            List<HashSet<(int, int)>> groups = new List<HashSet<(int, int)>>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        // If this space doesn't belong to a known group, then find all
                        // of the members it is connected to.
                        if (!groups.Any(group => group.Contains((i, j))))
                        {
                            HashSet<(int, int)> newGroup = new HashSet<(int, int)>();
                            newGroup.Add((i, j));

                            HashSet<(int, int)> seen = new HashSet<(int, int)>();
                            seen.Add((i, j));

                            this._findConnectedGroup(grid, (i, j), newGroup, seen);
                            groups.Add(newGroup);
                        }
                    }
                }
            }

            return groups.Count();
        }

        private void _findConnectedGroup(int[][] grid, (int x, int y) position, HashSet<(int, int)> group, HashSet<(int, int)> seen)
        {
            int x = position.x;
            int y = position.y;

            // Are we still in the grid?
            if ((x >= 0 && x < grid.Length) && (y >= 0 && y < grid[0].Length))
            {
                // If this square is a 1, add it.
                if (grid[x][y] == 1)
                {
                    group.Add((x, y));
                    seen.Add((x, y));
            
                    // Check all of the connected squares.
                    if (!seen.Contains((x - 1, y)))
                    {
                        _findConnectedGroup(grid, (x - 1, y), group, seen);
                    }

                    if (!seen.Contains((x + 1, y)))
                    {
                        _findConnectedGroup(grid, (x + 1, y), group, seen);
                    }

                    if (!seen.Contains((x, y - 1)))
                    {
                        _findConnectedGroup(grid, (x, y - 1), group, seen);
                    }
                    
                    if (!seen.Contains((x, y + 1)))
                    {
                        _findConnectedGroup(grid, (x, y + 1), group, seen);
                    }
                }
            }

            return;
        }
    }
}