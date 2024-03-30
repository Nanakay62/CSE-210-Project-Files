using System.Collections.Generic;
using System.IO; // Added for file I/O
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

  public void RecordEvent(string goalName)
{
  foreach (Goal goal in Goals)
  {
    if (goal.Name == goalName)
    {
      goal.RecordEvent();
      Score += goal.GetPoints();
      break;
    }
  }
}

  public int GetScore()
  {
    return Score;
  }

  public List<Goal> GetGoals()
  {
    return Goals;
  }


  /// <param name="filename">The name of the file to save to.</param>
  public void Save(string filename)
{
    // Serialize the goals and score to a JSON string
    string data = JsonSerializer.Serialize(this);

    // Write the serialized data to the file
    File.WriteAllText(filename, data);
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
    string data = File.ReadAllText(filename);
    EternalQuest loadedQuest = JsonSerializer.Deserialize<EternalQuest>(data);
    this.Goals = loadedQuest.Goals;
    this.Score = loadedQuest.Score;
    Console.WriteLine("Progress loaded!");
  }
  catch (Exception e)
  {
    Console.WriteLine($"An error occurred while loading progress: {e.Message}");
  }
}
}