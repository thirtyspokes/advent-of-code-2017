using Day11.Models;
using Day11.Services;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Day11.Services
{
    public class HexWalker
    {
        private readonly IInputReader _reader;

        public HexWalker(IInputReader reader)
        {
            _reader = reader;
        }

        public int ShortestDistanceFromStart(string input)
        {   
            IEnumerable<Move> steps = _reader.ReadInput(input)
                .Select(x => this._getMoveFromDirection(x));

            Hex start = new Hex(0, 0, 0);
            var tile = start;

            foreach (Move step in steps)
            {
                tile = this._moveTile(tile, step);
            }

            return (Math.Abs(start.X - tile.X) + Math.Abs(start.Y - tile.Y) + Math.Abs(start.Z - tile.Z)) / 2;
        }

        public int FarthestDistanceFromStart(string input)
        {   
            IEnumerable<Move> steps = _reader.ReadInput(input)
                .Select(x => this._getMoveFromDirection(x));

            var maxDistance = 0;
            Hex start = new Hex(0, 0, 0);
            Hex tile = start;

            foreach (Move step in steps)
            {
                tile = this._moveTile(tile, step);
                var distance = (Math.Abs(start.X - tile.X) + Math.Abs(start.Y - tile.Y) + Math.Abs(start.Z - tile.Z)) / 2;

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                }
            }

            return maxDistance;
        }

        private Hex _moveTile(Hex tile, Move move)
        {
            return new Hex(tile.X + move.X, tile.Y + move.Y, tile.Z + move.Z);
        }

        private Move _getMoveFromDirection(string direction)
        {
            switch(direction)
            {
                case "n":
                    return new Move(0, 1, -1);
                case "ne":
                    return new Move(1, 0, -1);
                case "nw":
                    return new Move(-1, 1, 0);
                case "sw":
                    return new Move(-1, 0, 1);
                case "se":
                    return new Move(1, -1, 0);
                case "s":
                    return new Move(0, -1, 1);
                default:
                    throw new ArgumentException(direction + " is not a valid hex direction.");
            }
        }
    }
}