using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you showed courage.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it successful?",
        "How can you use this again?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "Reflect on moments of strength and resilience."
        )
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        ShowSpinner(4);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        EndActivity();
    }
}
