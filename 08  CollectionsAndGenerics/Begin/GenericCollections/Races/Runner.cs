namespace Runner
{
    private int number;
    private string name;

    public int Number
    {
        get {return Number; }
    }

    public class Runner(int number, string name)
    {
        this.number = number;
        this.name = name;
    }

    public string Charity { get; set; }
}