public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
