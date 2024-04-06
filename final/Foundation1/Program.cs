using System;
public class Program
{
    public static void Main(string[] args)
    {
        var video1 = new Video { Title = "PND Podcast", Author = "Nana Kwame Dickson", Length = 120 };
        video1.AddComment(new Comment { CommenterName = "Ulyses", Text = "Great video!" });
        video1.AddComment(new Comment { CommenterName = "Klaus", Text = "Thanks for sharing!" });

        var video2 = new Video { Title = "New Age", Author = "Ms_Anti", Length = 510 };
        video2.AddComment(new Comment { CommenterName = "Emmanuel", Text = "Very informative." });
        video2.AddComment(new Comment { CommenterName = "Obed", Text = "Very informative." });

        var video3 = new Video { Title = "Plulumbum", Author = "Trevor", Length = 60 };
        video3.AddComment(new Comment { CommenterName = "Owura", Text = "Carries Substance." });
        video3.AddComment(new Comment { CommenterName = "Jane", Text = "It is very good." });

        var video4 = new Video { Title = "Reneged", Author = "Nico", Length = 210 };
        video4.AddComment(new Comment { CommenterName = "David", Text = "More vim." });
        video4.AddComment(new Comment { CommenterName = "John", Text = "I love this one." });



        var videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.Text}");
            }
        }
    }
}

