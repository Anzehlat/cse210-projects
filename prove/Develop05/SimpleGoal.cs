class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value, int level) : base(name, value, level) { }

    public override bool IsCompleted()
    {
        return true;
    }
}