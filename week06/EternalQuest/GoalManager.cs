using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // Exceeding requirement: Level system
    private int _level = 1;

    public void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_score} | Level: {_level}\n");
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        int newLevel = _score / 500 + 1;

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 Level Up! You are now Level {_level}!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine($"{_score}|{_level}");

            foreach (Goal g in _goals)
                output.WriteLine(g.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);
        _goals.Clear();

        string[] scoreParts = lines[0].Split("|");
        _score = int.Parse(scoreParts[0]);
        _level = int.Parse(scoreParts[1]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                var goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(
                    data[0], data[1],
                    int.Parse(data[2]),
                    int.Parse(data[4]),
                    int.Parse(data[3]));
                _goals.Add(goal);
            }
        }
    }
}
