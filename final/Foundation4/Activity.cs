class Activity
{
    private DateTime date;
    public int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} ({lengthMinutes} min)";
    }
}