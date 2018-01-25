using System;
using System.Collections.Generic;
using System.Linq;

namespace Day16.Domain
{
    public class Partner : IDanceStep
    {
        public char First { get; private set; }
        public char Second { get; private set; }

        public Partner(char first, char second)
        {
            this.First = first;
            this.Second = second;
        }

        public char[] ApplyStep(char[] programs)
        {
            char[] copy = programs.Select(x => x).ToArray();

            int firstIndex = Array.IndexOf(copy, this.First);
            int secondIndex = Array.IndexOf(copy, this.Second);

            var temp = copy[firstIndex];
            copy[firstIndex] = copy[secondIndex];
            copy[secondIndex] = temp;

            return copy;
        }

        public static Partner CreateFromString(string input)
        {
            var components = input.Skip(1).Where(x => x != '/').ToArray();
            return new Partner(components[0], components[1]);
        }
    }
}