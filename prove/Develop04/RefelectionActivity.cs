using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectionActivity(int duration) : base(duration)
    {
        prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            // Add more prompts here
        };
        questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            // Add more questions here
        };
    }

    public override void Perform()
    {
        StartMessage();
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);
        }
        EndMessage();
    }
}