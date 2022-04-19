namespace Races
{
    public class Race
    {
        public Dictionary<int, Runner> Runners = new Dictionary<int, Runner>();
        public Runner GetWinner(int number)
        {
            return Runner[number];
        }

        public void Add(Runner runner)
        {
            Runners.Add(runner.Number, runner);
        }

    }
}