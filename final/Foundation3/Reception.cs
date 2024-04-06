public class Reception : Event
{
    public string RSVPEmail { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {RSVPEmail}";
    }
}