class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        // Create activities
        var run = new Running(DateTime.Now, 30, 5);
        var cycle = new Cycling(DateTime.Now, 30, 20);
        var swim = new Swimming(DateTime.Now, 30, 20);

        // Display summaries
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}