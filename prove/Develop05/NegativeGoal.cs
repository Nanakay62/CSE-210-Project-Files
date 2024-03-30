public class NegativeGoal : Goal
{
  public NegativeGoal(string name, string description, int points) : base(name, description, -points) // Negative points
  {
  }

  public override void RecordEvent()
  {
    Completed = true;
  }
}