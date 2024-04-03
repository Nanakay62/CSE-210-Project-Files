using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6. Quit");
      Console.Write("Enter your choice: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          AddGoal(quest);
          break;
        case "2":
          ViewGoals(quest);
          break;
        case "3":
          Console.Write("Enter filename to save: ");
          string saveFile = Console.ReadLine();
          quest.Save(saveFile);
          Console.WriteLine("Progress saved!");
          break;
        case "4":
          Console.Write("Enter filename to load: ");
          string loadFile = Console.ReadLine();
          quest.Load(loadFile);
          Console.WriteLine("Progress loaded!");
          break;
        case "5":
          RecordEvent(quest);
          break;
        case "6":
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
    Console.WriteLine("The goal types are:");
    Console.WriteLine("1. Simple goal");
    Console.WriteLine("2. Eternal goal");
    Console.WriteLine("3. Checklist goal");
    Console.Write("Which type of goal would you like to create? ");

    string goalType = Console.ReadLine();

    Console.Write("Enter the name of your goal: ");
    string goalName = Console.ReadLine();

    Console.Write("Enter the description of your goal: ");
    string goalDescription = Console.ReadLine();

    Console.Write("Enter the score of your goal: ");
    int goalScore = int.Parse(Console.ReadLine());

    switch (goalType)
    {
      case "1":
        quest.AddGoal(new SimpleGoal(goalName, goalDescription, goalScore));
        break;
      case "2":
        quest.AddGoal(new EternalGoal(goalName, goalDescription, goalScore));
        break;
      case "3":
        Console.Write("Enter the target completions of your goal: ");
        int targetCompletions = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points of your goal: ");
        int bonusPoints = int.Parse(Console.ReadLine());
        quest.AddGoal(new ChecklistGoal(goalName, goalDescription, goalScore, targetCompletions, bonusPoints));
        break;
      default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
    }
  }

  static void RecordEvent(EternalQuest quest)
  {
    Console.Write("Which goal did you accomplish? ");
    int goalNumber = int.Parse(Console.ReadLine());
    Goal goal = quest.GetGoals()[goalNumber - 1];
    quest.RecordEvent(goalNumber);
    Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
    Console.WriteLine($"You now have {quest.GetScore()} points.");
  }

  static void ViewGoals(EternalQuest quest)
  {
    Console.WriteLine("\nYour Goals:");
    int goalNumber = 1;
    foreach (Goal goal in quest.GetGoals())
    {
      string checkmark = goal.IsCompleted() ? "[x]" : "[ ]";
      string completions = goal is ChecklistGoal ? $" -- Currently completed: {((ChecklistGoal)goal).Completions}/{((ChecklistGoal)goal).TargetCompletions}" : "";
      Console.WriteLine($"{goalNumber}. {checkmark} {goal.Name} ({goal.Description}){completions}");
      goalNumber++;
    }
    Console.WriteLine($"You now have {quest.GetScore()} points.");
  }
}