using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<string, int> _activityCount = new Dictionary<string, int>();
    private static Logger _logger = new Logger("activityLog.txt");

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                break;
            }
            Console.WriteLine("Enter the duration for the activity (in seconds):");
            int duration = int.Parse(Console.ReadLine());

            Activity activity = null;
            string activityName = "";

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(duration);
                    activityName = "Breathing";
                    break;
                case "2":
                    activity = new ReflectionActivity(duration);
                    activityName = "Reflection";
                    break;
                case "3":
                    activity = new ListingActivity(duration);
                    activityName = "Listing";
                    break;
            }
            // Stretch, keeping log of how many times activities were performed
            if (activity != null)
            {
                activity.Perform();
                //Log the activity
                _logger.LogActivity(activityName);
                // Updating the activity count
                if (_activityCount.ContainsKey(activityName))
                {
                    _activityCount[activityName]++;
                }
                else
                {
                    _activityCount[activityName] = 1;
                }
                // Display the count for the activity
                Console.WriteLine($"You have performed {activityName} activity {_activityCount[activityName]} times.");
            }
        }

        // At the end of the session, you can read and display the log
        Console.WriteLine("Session ended. Here's the log of all activities performed:");
        Console.WriteLine(_logger.ReadLog());
    }
}