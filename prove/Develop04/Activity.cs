using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    protected Activity(int duration)
    {
        this.duration = duration;
    }

    protected void StartMessage()
    {
        Console.WriteLine("Welcome to the {0} activity!", GetType().Name);
        Console.WriteLine("This activity will take {0} seconds.", duration);
        Console.WriteLine("Please get ready and press Enter to begin.");
        Console.ReadLine();
        Console.WriteLine("Starting in...");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i + "...");
            Thread.Sleep(1000);
        }
    }

    protected void EndMessage()
    {
        Console.WriteLine("You did a great job!");
        Thread.Sleep(2000);
        Console.WriteLine("You completed the {0} activity.", GetType().Name);
        Thread.Sleep(2000);
    }

    public abstract void Perform();
}