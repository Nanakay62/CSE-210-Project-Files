using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Perform()
    {
        StartMessage();
        string[] messages = { "Breathe in...", "Breathe out..." };
        for (int i = 0; i < duration / 2; i++)
        {
            Console.WriteLine(messages[i % 2]);
            Thread.Sleep(2000);
        }
        EndMessage();
    }
}