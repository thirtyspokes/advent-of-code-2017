using System.Collections.Generic;

namespace Day9
{
    public class StreamProcessor
    {
        public StreamProcessor()
        {
        }

        public int ProcessStreamScore(string input)
        {
            char[] chars = input.ToCharArray();

            bool ignore = false;
            bool insideGarbage = false;

            int nestingLevel = 0;
            int score = 0;

            foreach (char c in chars)
            {
                if (!ignore)
                {
                    if (c == '{' && !insideGarbage)
                    {
                        nestingLevel++;
                    }
                    else if (c == '}' && !insideGarbage)
                    {
                        score += nestingLevel;
                        nestingLevel--;
                    }
                    else if (c == '<' && !insideGarbage)
                    {
                        insideGarbage = true;
                    }
                    else if (c == '>')
                    {
                        if (insideGarbage)
                        {
                            insideGarbage = false;
                        }
                    }
                    else if (c == '!')
                    {
                        ignore = true;
                    }
                }
                else {
                    ignore = false;
                }
            }

            return score;
        }

        public int ProcessGarbageLength(string input)
        {
            char[] chars = input.ToCharArray();

            bool ignore = false;
            bool insideGarbage = false;

            int garbageLength = 0;

            foreach (char c in chars)
            {
                if (!ignore)
                {
                    if (c == '<' && !insideGarbage)
                    {
                        insideGarbage = true;
                    }
                    else if (c == '>')
                    {
                        if (insideGarbage)
                        {
                            insideGarbage = false;  
                        }
                    }
                    else if (c == '!')
                    {
                        ignore = true;
                    }
                    else if (insideGarbage)
                    {
                        garbageLength++;
                    }
                }
                else {
                    ignore = false;
                }
            }

            return garbageLength;
        }
    }
}