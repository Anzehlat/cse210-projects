using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 13:34-35";
        string text = "A new commandment I give unto you, That ye love one another; as I have loved you, that ye also love one another." +
                      "By this shall all men know that ye are my disciples, if ye have love one to another.";

        Scripture scripture = new Scripture(reference, text);

        do
        {
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            //Hides a random word
            scripture.HideRandomWords(1);

        } while (!scripture.AllWordsHidden());
    }
}