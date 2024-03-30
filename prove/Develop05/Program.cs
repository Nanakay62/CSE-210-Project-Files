using System;

class Program
{
  static void Main(string[] args)
  {
    EternalQuest quest = new EternalQuest();

    // Sample goals
    quest.AddGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon race", 1000));
    quest.AddGoal(new EternalGoal("Scripture Study", "Read scriptures daily", 100));
    quest.AddGoal(new ChecklistGoal("Temple Attendance", "Attend the temple regularly", 50, 10, 500));
    quest.AddGoal(new ProgressGoal("Learning Piano", "Practice piano for a total of 10 hours", 200, 10, 20));
    quest.AddGoal(new NegativeGoal("Break the Fast", "Avoid breaking the fast", -50));

    // User Interaction loop
    while (true)
    {
      Console.WriteLine("\nEternal Quest Menu:");
      Console.WriteLine("1. Add Goal");
      Console.WriteLine("2. Record Event");
      Console.WriteLine("3. View Goals");
      Console.WriteLine("4. View Score");
      Console.WriteLine("5. Save Progress");
      Console.WriteLine("6. Load Progress");
      Console.WriteLine("7. Exit");
      Console.Write("Enter your choice: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          AddGoal(quest);
          break;
        case "2":
          RecordEvent(quest); // Added method call
          break;
        case "3":
          ViewGoals(quest); // Added method call
          break;
        case "4":
          Console.WriteLine($"Current Score: {quest.GetScore()}");
          break;
        case "5":
          Console.Write("Enter filename to save: ");
          string saveFile = Console.ReadLine();
          quest.Save(saveFile);
          Console.WriteLine("Progress saved!");
          break;
        case "6":
          Console.Write("Enter filename to load: ");
          string loadFile = Console.ReadLine();
          quest.Load(loadFile);
          Console.WriteLine("Progress loaded!");
          break;
        case "7":
          Console.WriteLine("Exiting Eternal Quest...");
          return;
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }
    }
  }

  static void AddGoal(EternalQuest quest)
  {
     Console.Write("Enter the name of your goal: ");
  string goalName = Console.ReadLine();

  Console.Write("Enter the description of your goal: ");
  string goalDescription = Console.ReadLine();

  Console.Write("Enter the score of your goal: ");
  int goalScore = int.Parse(Console.ReadLine());

  quest.AddGoal(new SimpleGoal(goalName, goalDescription, goalScore));
  }


  /// <param name="quest">The EternalQuest object to record the event for.</param>
  static void RecordEvent(EternalQuest quest)
  {
    Console.Write("Enter the name of the goal you completed: ");
    string goalName = Console.ReadLine();
    quest.RecordEvent(goalName); // Call RecordEvent on the EternalQuest object
  }
  /// <param name="quest">The EternalQuest object containing the goals.</param>
  static void ViewGoals(EternalQuest quest)
  {
    Console.WriteLine("\nYour Goals:");
    foreach (Goal goal in quest.GetGoals())
    {
      Console.WriteLine($"- {goal.Name} ({goal.Description})");
      if (goal.IsCompleted())
      {
        Console.WriteLine("  Completed!");
      }
      else
      {
        Console.WriteLine("  Not completed.");
      }
    }
  }
}