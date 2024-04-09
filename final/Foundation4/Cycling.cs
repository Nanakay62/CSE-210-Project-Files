public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, double lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * LengthInMinutes;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({LengthInMinutes} min) - " + base.GetSummary();
    }
}