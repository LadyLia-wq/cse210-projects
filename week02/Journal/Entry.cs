public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2]);
    }

    public void Display()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("--------------------------------------------------");
    }
}
