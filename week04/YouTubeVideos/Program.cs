using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learning C# Basics", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        v1.AddComment(new Comment("Bob", "Great explanation."));
        v1.AddComment(new Comment("Charlie", "Thanks for sharing."));
        videos.Add(v1);

        Video v2 = new Video("Web Development Guide", "DevWorld", 720);
        v2.AddComment(new Comment("David", "Awesome content!"));
        v2.AddComment(new Comment("Eva", "Loved the examples."));
        v2.AddComment(new Comment("Frank", "Very clear instructions."));
        videos.Add(v2);

        Video v3 = new Video("Database Design Tips", "TechGuru", 500);
        v3.AddComment(new Comment("Grace", "Learned a lot."));
        v3.AddComment(new Comment("Henry", "Very informative."));
        v3.AddComment(new Comment("Isabel", "Excellent video."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Comments: " + video.GetCommentCount());

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" - {comment._authorName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
