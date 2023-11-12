using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person you've interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was one of the most strongest emotion I had felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are your goals for tomorrow?",
        "What is one high and one low you've had today?"
    };

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? (1-5)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(myJournal);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    myJournal.LoadFromFile();
                    break;

                case "4":
                    myJournal.SaveToFile();
                    break;
                
                //added a note when done writing an entry for the day
                case "5":
                    Console.WriteLine("Thank you for journaling today. Goodbye!");
                    return;
                //added a default. It's always good to have a back up error message for the user 
                default:
                    Console.WriteLine("Sorry, that was an invalid choice. Try again.");
                    break;
            }
        }
    }

//Get random prompt from list
    static void WriteEntry(Journal journal)
    {
        string randomPrompt = GetRandomPrompt();

        Console.WriteLine($"{randomPrompt}");
        string userResponse = Console.ReadLine();

        Entry newEntry = new Entry
        {
            Prompt = randomPrompt,
            Response = userResponse,
            Date = DateTime.Now
        };

        journal.AddEntry(newEntry);
        Console.WriteLine("Entry Saved!");
    }

    static string GetRandomPrompt()
    {
        //added if 0, no prompts are available
        if (prompts.Count == 0)
        {
            return "No prompts available.";
        }

//return prompt
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}