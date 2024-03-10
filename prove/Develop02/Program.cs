using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
          Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(promptGenerator.GetRandomPrompt());
                    var entryText = Console.ReadLine();
                    journal.AddEntry(new Entry { Date = DateTime.Now, PromptText = promptGenerator.GetRandomPrompt(), EntryText = entryText });
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the filename to load from:");
                    var loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Enter the filename to save to:");
                    var saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5":
                    return;
            }
        }
    }
    }

// Added code to improve the process of saving and loading to save as a .csv file that could be opened in Excel.
        
    
