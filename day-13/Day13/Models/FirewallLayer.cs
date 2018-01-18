namespace Day13.Models
{
    public class FirewallLayer
    {
        public int Range { get; private set; }

        private bool _hasScanner;

        public FirewallLayer(int range, bool scanner)
        {
            Range = range;
            _hasScanner = scanner;
        }

        public bool SafeAtTime(int time)
        {
            // If there's no scanner here this layer is safe at any time.
            if (!this._hasScanner) return true;

            // If there is only one space for the scanner, then this layer is never safe.
            if (this.Range == 1) return false;

            // Otherwise, a layer is safe at a given time if the scanner isn't in position zero
            // when the packet enters it. A scanner will fully traverse a layer in 2n - 2 picoseconds.
            return time % ((2 * this.Range) - 2) != 0;
        }

    }
}