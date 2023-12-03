class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int value, int level, int targetCount) : base(name, value, level)
    {
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Console.WriteLine($"Congratulations! You completed the goal: {name}. Earned {value} points. ({completedCount}/{targetCount})");

        if (completedCount % 5 == 0)
        {
            LevelUp(); // Level up every 5 completions
        }

        if (IsCompleted())
        {
            Console.WriteLine($"Bonus: {GetValue() * targetCount} points for completing the checklist goal!");
        }
    }

    public override bool IsCompleted()
    {
        return completedCount >= targetCount;
    }
}
