public class ProgressGoal : Goal
{
  public int TotalProgress { get; private set; }
  public int IncrementValue { get; private set; }

  public ProgressGoal(string name, string description, int points, int totalProgress, int incrementValue) : base(name, description, points)
  {
    TotalProgress = totalProgress;
    IncrementValue = incrementValue;
  }

  public override void RecordEvent()
  {
    Progress += IncrementValue;
  Completed = Progress >= TotalProgress;
  }

  public int Progress { get; private set; }

  public void AddProgress(int value)
  {
    Progress = Math.Min(Progress + value, TotalProgress);
  }
}