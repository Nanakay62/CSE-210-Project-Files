public abstract class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public string GetStandardDetails()
    {
        return $"{Title}\n{Description}\n{Date}\n{Time}\n{Address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {Title} on {Date.ToShortDateString()}";
    }
}