namespace Day13.Models
{
    public class Packet
    {
        public Packet()
        {
        }

        public int GetTravelCost(Firewall firewall)
        {
            int cost = 0;

            for (int i = 0; i < firewall.Depth(); i++)
            {
                // Each time the alarm will be triggered by us moving into it,
                // we increment the cost by the depth into the firewall we're at
                // times the depth of the layer we are entering.
                if (firewall.AlarmWillBeTriggered(i, i))
                {
                    cost += i * firewall.RangeAtDepth(i);
                }
            }

            return cost;
        }

        public int GetDelayForNoAlarms(Firewall firewall)
        {
            int delay = 0;
            bool safe = false;

            while (!safe)
            {
                bool earlyBreak = false;

                for (int i = 0; i < firewall.Depth(); i++)
                {
                    if (firewall.AlarmWillBeTriggered(i, i + delay))
                    {
                        // This delay is no good, so increase the delay and try again.
                        delay++;
                        earlyBreak = true;
                        break;
                    }
                }

                // If at no point we terminated the loop early, then every layer will
                // be safe as we travel through, so we've found the necessary delay.
                if (!earlyBreak) 
                {
                    safe = true;
                }
            }
            
            return delay;
        }
    }
}