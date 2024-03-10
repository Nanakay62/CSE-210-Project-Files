using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public DateTime Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}  {EntryText}" );
        
    }
}
