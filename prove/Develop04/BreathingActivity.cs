class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by breathing in and out slowly") { }

    protected override void PerformActivity(int duration)
    {
        string[] breathMessages = { "Breathe in...", "Breathe out..." };
        for (int i = 0; i < duration; i++)
        {
            foreach (var message in breathMessages)
            {
                Console.WriteLine(message);
                Thread.Sleep(1000);
            }
        }
    }
}
