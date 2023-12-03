using System;
using System.Threading;

class MindfulnessActivity
{
    protected static Log log = new Log();
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void StartActivity(int duration)
    {
        DisplayStartingMessage();
        Thread.Sleep(3000); // Pause for user to prepare

        PerformActivity(duration);
        log.LogActivity(name); // Log the activity

        Thread.Sleep(3000); // Pause before displaying ending message
        DisplayEndingMessage(duration);
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Get ready for {name} - {description}");
    }

    protected void DisplayEndingMessage(int duration)
    {
        Console.WriteLine($"Good job! You completed {name} for {duration} seconds.");
    }

    protected virtual void PerformActivity(int duration)
    {
        throw new NotImplementedException("Subclasses must implement PerformActivity");
    }
}