using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Sir Beast 1: Video 1", "JimmyOne", 111);
        Video video2 = new Video("Sir Beast 2: Video 2", "JimmyTwo", 222);
        Video video3 = new Video("Sir Beast 3: Video 3", "JimmyThree", 333);

        video1.AddComment(new Comment("User1", "First Comment!"));
        video2.AddComment(new Comment("User2", "Second Comment!"));
        video3.AddComment(new Comment("User3", "Third Comment!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"** Video Details **");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}"); // Replace "Title" with "Author"
            Console.WriteLine($"Length: {video.Length} seconds"); // Replace "Title" with "Length"
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\n Comments ");

            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($" {comment.Name} : {comment.Text}");
            }

            Console.WriteLine("\n===============================\n");
        }
    }
}
