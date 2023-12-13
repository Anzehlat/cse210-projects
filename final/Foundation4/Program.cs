using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity type
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 9, 21), 30, 3.0),
            new StationaryBicycles(new DateTime(2023, 12, 16), 30, 25.0),
            new Swimming(new DateTime(2023, 07, 27), 30, 20)
        };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}