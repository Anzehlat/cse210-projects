using System;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        //make videos and create comments
        Video video1 = new Video("Introduction to C#", "C# Expert", 275);
        video1.AddComment("Robert", "Great tutorial!");
        video1.AddComment("Mark", "I learned a lot. Thank you!");
        video1.AddComment("Ally", "This is great. Could you make more videos like this?");

        Video video2 = new Video("Web Development Basics", "CodeMaster", 530);
        video2.AddComment("Stephanie", "Thanks for sharing!");
        video2.AddComment("Kara", "Very informative.");
        video2.AddComment("Lilah", "I have a question about CSS..");

        Video video3 = new Video("Basic CSS and HTML", "Web Design for Starters", 625);
        video3.AddComment("Zehla", "Great web design skills!");
        video3.AddComment("Talia", "Can you add the links to the programs you used?");
        video3.AddComment("Tele", "How do you change the font of the Header?");

        //list of videos
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        //info for videos
        foreach (var video in videoList)
        {
            Console.WriteLine("Title:" + video.Title);
            Console.WriteLine("Author:" + video.Author);
            Console.WriteLine("Length:" + video.Length + " seconds");
            Console.WriteLine("Number of Comments:" + video.GetNumComments());


            //show the comments for video
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine("\t" + comment.CommenterName + " : " + comment.CommentText);
            }

            Console.WriteLine("\n"); //line break between videos
        }
    }
}