public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        //list of prompts 
        _prompts = new List<string>
        {
        "Who was the most interesting person you've interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was one of the most strongest emotion I had felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are your goals for tomorrow?",
        "What is one high and one low you've had today?"
        };
    }
//generate a random prompt for user
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
