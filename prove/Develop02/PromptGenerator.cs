public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What would make you smile brighter today? ",
        "What would you say was the greatest day of your life? ",
        "Did I read my quiet time today? ",
        "Would I want to meditate on the word of God today? ",
        "What productive thing would make me the most happiest today? ",
        "Do I recall Ba Sing Se? ",
        "When I think about my mother, what is my reaction? "
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}