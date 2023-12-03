using System;
using System.Collections.Generic;
using System.Threading;

class Log
{
    private Dictionary<string, int> activityCounts = new Dictionary<string, int>();

    public void LogActivity(string activityName)
    {
        if (!activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName] = 1;
        }
        else
        {
            activityCounts[activityName]++;
        }
    }

    public void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var kvp in activityCounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
        }
    }
}
