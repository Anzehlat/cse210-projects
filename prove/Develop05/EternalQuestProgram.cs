class EternalQuestProgram
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.RecordEvent();
            totalScore += goal.GetValue();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            goals[i].DisplayStatus();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your Total Score: {totalScore} points");
    }

    public void SaveProgress()
    {
        // Implement saving progress logic
        Console.WriteLine("Progress saved!");
    }

    public void LoadProgress()
    {
        // Implement loading progress logic
        Console.WriteLine("Progress loaded!");
    }
}