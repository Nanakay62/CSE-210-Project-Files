public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, double lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({LengthInMinutes} min) - " + base.GetSummary();
    }
}
