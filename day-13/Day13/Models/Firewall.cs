namespace Day13.Models
{
    public class Firewall
    {
        private readonly FirewallLayer[] _layers;

        public Firewall(FirewallLayer[] layers)
        {
            _layers = layers;
        }

        public int Depth()
        {
            return _layers.Length;
        }

        public int RangeAtDepth(int depth)
        {
            return _layers[depth].Range;
        }

        // An alarm will be triggered if the scanner is in position 0 when
        // the packet moves into it.
        public bool AlarmWillBeTriggered(int depth, int time)
        {
            return !_layers[depth].SafeAtTime(time);
        }
    }
}