class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Stationary Bikes - Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}