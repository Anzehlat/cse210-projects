using System;

class Program
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        breathingActivity.StartActivity(5);
        reflectionActivity.StartActivity(8);
        listingActivity.StartActivity(10);
    }
}
