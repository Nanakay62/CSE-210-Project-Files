public class Swimming : Activity
{
    public double NumberOfLaps { get; set; }

    public Swimming(DateTime date, double lengthInMinutes, double numberOfLaps)
        : base(date, lengthInMinutes)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (NumberOfLaps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({LengthInMinutes} min) - " + base.GetSummary();
    }
}