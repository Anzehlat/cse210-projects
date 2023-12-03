class ReflectionActivity : MindfulnessActivity
{
    private string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times of strength and resilience") { }

    protected override void PerformActivity(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            string prompt = reflectionPrompts[new Random().Next(reflectionPrompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(2000);
            AskReflectionQuestions();
        }
    }

    private void AskReflectionQuestions()
    {
        string[] reflectionQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
        };
        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000);
        }
    }
}
