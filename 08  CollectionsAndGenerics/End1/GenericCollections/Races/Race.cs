using System;
using System.Collections.Generic;
using System.Text;

namespace Races
{
    public class Race
    {
        Dictionary<int, Runner> runners = new Dictionary<int, Runner>();

        public void Add(Runner runner)
        {
            runners.Add(runner.Number, runner);
        }

        public Runner GetWinner(int number)
        {
            return runners?[number];
        }
    }
}
