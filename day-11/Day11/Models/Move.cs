namespace Day11.Models
{
    public class Move
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Move(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}