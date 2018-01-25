using System;
using System.Linq;

namespace Day16.Domain
{
    public class Exchange : IDanceStep
    {
        public int First { get; private set; }
        public int Second { get; private set; }

        public Exchange(int first, int second)
        {
            this.First = first;
            this.Second = second;
        }

        public char[] ApplyStep(char[] programs)
        {
            char[] copy = programs.Select(x => x).ToArray();

            char temp = copy[this.First];
            copy[this.First] = copy[this.Second];
            copy[this.Second] = temp;

            return copy;
        }

        public static Exchange CreateFromString(string input)
        {
            var components = String.Join("", input.Skip(1)).Split("/", StringSplitOptions.RemoveEmptyEntries);
            return new Exchange(Int32.Parse(components[0]), Int32.Parse(components[1]));
        }
    }
}