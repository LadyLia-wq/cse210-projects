/*
EXCEEDING REQUIREMENTS

This program exceeds the Eternal Quest requirements by adding
a Level System. Users level up automatically as they gain points.
Every 500 points increases their level and displays a celebration
message.

This gamification feature motivates users to continue completing
goals and makes progress more rewarding.
*/

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            manager.DisplayScore();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                int type = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                    manager.AddGoal(new SimpleGoal(name, desc, points));

                else if (type == 2)
                    manager.AddGoal(new EternalGoal(name, desc, points));

                else
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(
                        new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == 2)
                manager.ListGoals();

            else if (choice == 3)
                manager.RecordEvent();

            else if (choice == 4)
                manager.SaveGoals();

            else if (choice == 5)
                manager.LoadGoals();
        }
    }
}
