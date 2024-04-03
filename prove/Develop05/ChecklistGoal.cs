public class ChecklistGoal : Goal
{
    public int TargetCompletions { get; set; }
    public int BonusPoints { get; set; }
    public int Completions { get; set; }

    // Parameterless constructor for deserialization
    public ChecklistGoal() : base("", "", 0)
    {
    }

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCompletions, int bonusPoints) : base(name, description, pointsPerEvent)
    {
        TargetCompletions = targetCompletions;
        BonusPoints = bonusPoints;
        Completions = 0;
    }

    public override void RecordEvent()
    {
        Completions++;
        if (Completions >= TargetCompletions)
        {
            Completed = true;
        }
    }

    public override int GetPoints()
    {
        if (Completed)
        {
            return Points * Completions + BonusPoints;
        }
        else
        {
            return Points * Completions;
        }
    }
}