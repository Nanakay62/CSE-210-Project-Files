using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts;

    public ListingActivity(int duration) : base(duration)
    {
        prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            // Add more prompts here
        };
    }

    public override void Perform()
    {
        StartMessage();
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Think for a few seconds and then start listing...");
        Thread.Sleep(3000);
        int itemCount = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                itemCount++;
            }
        }
        Console.WriteLine("Great! You listed {0} items.", itemCount);
        EndMessage();
    }
}