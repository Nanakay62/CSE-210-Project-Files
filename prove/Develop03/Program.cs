using System;

class Program
{
   static void Main(string[] args)
{
    var scriptures = new List<Scripture>
    {
        new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
        new Scripture(new Reference("Matthew", 28, 19), "Therefore go and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit."),
        new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
        new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
        new Scripture(new Reference("Psalm", 23, 1), "The LORD is my shepherd, I lack nothing."),
        new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you,” declares the LORD, “plans to prosper you and not to harm you, plans to give you hope and a future.")
    };

    foreach (var scripture in scriptures)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide some words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(2);
        }
        Console.Clear();
        Console.WriteLine("All words are hidden!");
    }
}
}
//Stretch
//  When user types "quit" another random scripture is generated to be chosen from and presented to the user.