using Day16.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day16.Services
{
    public class DanceStepParser
    {
        public DanceStepParser()
        {
        }

        public IEnumerable<IDanceStep> ParseSteps(string input)
        {
            var rawSteps = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            List<IDanceStep> steps = new List<IDanceStep>();

            foreach (var rawStep in rawSteps)
            {
                switch (rawStep.First())
                {
                    case 's':
                        steps.Add(Spin.CreateFromString(rawStep));
                        break;
                    case 'x':
                        steps.Add(Exchange.CreateFromString(rawStep));
                        break;
                    case 'p':
                        steps.Add(Partner.CreateFromString(rawStep));
                        break;
                    default:
                        throw new Exception("Unrecognized dance format: " + rawStep);
                }
            }
            return steps;
        }
    }
}