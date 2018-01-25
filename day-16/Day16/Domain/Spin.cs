using System;
using System.Collections.Generic;
using System.Linq;

namespace Day16.Domain
{
    public class Spin : IDanceStep
    {
        public int Amount { get; private set; }

        public Spin(int amount)
        {
            this.Amount = amount;
        }

        public char[] ApplyStep(char[] programs)
        {
            var tail = programs.Skip(Math.Max(0, programs.Length - this.Amount));
            return tail.Concat(programs.Take(Math.Max(0, programs.Length - this.Amount))).ToArray();
        }

        public static Spin CreateFromString(string input)
        {
            var tail = input.Substring(1);
            return new Spin(Int32.Parse(tail));
        }
    }
}