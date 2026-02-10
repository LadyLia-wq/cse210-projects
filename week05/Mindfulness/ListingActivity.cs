using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who inspires you?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "List positive things in your life."
        )
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    }
}
