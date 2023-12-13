using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        //instances for address class
        Address eventAddress1 = new Address("60 N West Temple", "Salt Lake City", "UT", "USA");
        Address eventAddress2 = new Address("185 N 1200 E", "Calgary", "Alberta", "Canada");
        Address eventAddress3 = new Address("14065 S Canyon Vista Ln", "Draper", "UT", "USA");
        Address eventAddress4 = new Address("Central Park", "New York", "NY", "USA");

    //instances for each event 
    Event genericEvent = new Event("General Conference", "April 2024 General Conference", DateTime.Now.AddDays(109), new TimeSpan(10, 00, 0), eventAddress1);
    Lecture lectureEvent = new Lecture("Emergency Preparedness", "The Principle of Preparation", DateTime.Now.AddDays(4), new TimeSpan(14, 0, 0), eventAddress2, "John Doe", 100);
    Reception receptionEvent = new Reception("Wedding", "Bobby & Zehla", DateTime.Now.AddDays(110), new TimeSpan(10, 0, 0), eventAddress3, "rsvp@theknot.com");
    OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy food, games, and live entertainment", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), eventAddress4, "Weather permitting");

    //Show marketing messages
    Console.WriteLine("Generic Event:");
    Console.WriteLine("Standard Details:\n" + genericEvent.GetStandardDetails() + "\n");
    Console.WriteLine("Full Details:\n" + genericEvent.GetFullDetails() + "\n");
    Console.WriteLine("Short Description:\n" + genericEvent.GetShortDescription() + "\n");

    Console.WriteLine("Lecture Event:");
    Console.WriteLine("Standard details:\n" + lectureEvent.GetStandardDetails() + "\n");
    Console.WriteLine("Full Details:\n" + lectureEvent.GetFullDetails() + "\n");
    Console.WriteLine("Short Description:\n" + lectureEvent.GetShortDescription() + "\n");

    Console.WriteLine("Reception Event:");
    Console.WriteLine("Standard details:\n" + receptionEvent.GetStandardDetails() + "\n");
    Console.WriteLine("Full Details:\n" + receptionEvent.GetFullDetails() + "\n");
    Console.WriteLine("Short Description:\n" + receptionEvent.GetShortDescription() + "\n");

    Console.WriteLine("Outdoor Gathering Event:");
    Console.WriteLine("Standard details:\n" + outdoorEvent.GetStandardDetails() + "\n");
    Console.WriteLine("Full Details:\n" + outdoorEvent.GetFullDetails() + "\n");
    Console.WriteLine("Short Description:\n" + outdoorEvent.GetShortDescription() + "\n");
    }
}