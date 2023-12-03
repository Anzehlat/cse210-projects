class ListingActivity : MindfulnessActivity
{
    public ListingActivity() : base("Listing Activity", "List as many positive things as you can in a certain area") { }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine("Who are people that you appreciate?");
        Thread.Sleep(3000);
        Console.WriteLine("Go!");

        int itemsListed = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput))
                break;
            itemsListed++;
        }

        Console.WriteLine($"You listed {itemsListed} items.");
    }
}