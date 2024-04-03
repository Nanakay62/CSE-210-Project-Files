using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class EternalQuest
{
  private List<Goal> Goals { get; set; }
  public int Score { get; private set; }

  public EternalQuest()
  {
    Goals = new List<Goal>();
    Score = 0;
  }

  public void AddGoal(Goal goal)
  {
    Goals.Add(goal);
  }

  public void RecordEvent(int goalNumber)
  {
    if (goalNumber < 1 || goalNumber > Goals.Count)
    {
      Console.WriteLine("Invalid goal number. Please try again.");
      return;
    }

    Goal goal = Goals[goalNumber - 1];
    goal.RecordEvent();
    Score += goal.GetPoints();
  }

  public int GetScore()
  {
    return Score;
  }

  public List<Goal> GetGoals()
  {
    return Goals;
  }

  public void Save(string filename)
  {
    using (StreamWriter file = new StreamWriter(filename))
    {
      file.WriteLine(Score);
      foreach (Goal goal in Goals)
      {
        string goalType = goal.GetType().Name;
        string goalData = JsonSerializer.Serialize(goal);
        file.WriteLine($"{goalType}:{goalData}");
      }
    }
  }

  public void Load(string filename)
  {
    if (!File.Exists(filename))
    {
      Console.WriteLine("The file you're trying to load does not exist.");
      return;
    }

    try
    {
      using (StreamReader file = new StreamReader(filename))
      {
        Score = int.Parse(file.ReadLine());
        Goals.Clear();
        string line;
        while ((line = file.ReadLine()) != null)
        {
          string[] parts = line.Split(':', 2);
          string goalType = parts[0];
          string goalData = parts[1];
          Goal goal = null;
          switch (goalType)
          {
            case nameof(SimpleGoal):
              goal = JsonSerializer.Deserialize<SimpleGoal>(goalData);
              break;
            case nameof(EternalGoal):
              goal = JsonSerializer.Deserialize<EternalGoal>(goalData);
              break;
            case nameof(ChecklistGoal):
              goal = JsonSerializer.Deserialize<ChecklistGoal>(goalData);
              break;
            case nameof(ProgressGoal):
              goal = JsonSerializer.Deserialize<ProgressGoal>(goalData);
              break;
            case nameof(NegativeGoal):
              goal = JsonSerializer.Deserialize<NegativeGoal>(goalData);
              break;
          }
          if (goal != null)
          {
            Goals.Add(goal);
          }
        }
      }
      Console.WriteLine("Progress loaded!");
    }
    catch (Exception e)
    {
      Console.WriteLine($"An error occurred while loading progress: {e.Message}");
    }
  }
}