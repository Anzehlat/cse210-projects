class Goal
{
    protected string name;
    protected int value;
    protected int level;

    public Goal(string name, int value, int level)
    {
        this.name = name;
        this.value = value;
        this.level = level;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You completed the goal: {name}. Earned {value} points and leveled up to Level {level}.");
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"[{(IsCompleted() ? 'X' : ' ')}] {name} (Level {level})");
    }

    public virtual bool IsCompleted()
    {
        return false;
    }

    public int GetValue()
    {
        return value * level; // Introduce level-based points
    }

    public void LevelUp()
    {
        level++;
        Console.WriteLine($"Congratulations! You leveled up {name} to Level {level}.");
    }
}