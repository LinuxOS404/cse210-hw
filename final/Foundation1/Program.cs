using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {   
    List<Video> videos = new List<Video>();

    Video video1 = new Video("Best Anime of 2025","AnimeCity",150);
    video1.AddComment(new Comment("Anime101","This was very good, I found one to watch"));
    video1.AddComment(new Comment("Anime102","Never thought that one would be on the list"));
    video1.AddComment(new Comment("Anime103","Watch Serason 2 it's pretty great"));
    video1.AddComment(new Comment("Anime104","Yay! More Anime!"));

    videos.Add(video1);

    Video video2 = new Video("Best Anime of 2025","AnimeCity",120);
    video2.AddComment(new Comment("Anime101","This was very good, I found one to watch"));
    video2.AddComment(new Comment("Anime102","Never thought that one would be on the list"));
    video2.AddComment(new Comment("Anime103","Watch Serason 2 it's pretty great"));
    video2.AddComment(new Comment("Anime104","Yay! More Anime!"));
    
    videos.Add(video2);
    
    Video video3 = new Video("Best Anime of 2025","AnimeCity",330);
    video3.AddComment(new Comment("Anime101","This was very good, I found one to watch"));
    video3.AddComment(new Comment("Anime102","Never thought that one would be on the list"));
    video3.AddComment(new Comment("Anime103","Watch Serason 2 it's pretty great"));
    video3.AddComment(new Comment("Anime104","Yay! More Anime!"));

    videos.Add(video3);

    Video video4 = new Video("Best Anime of 2025","AnimeCity",110);
    video4.AddComment(new Comment("Anime101","This was very good, I found one to watch"));
    video4.AddComment(new Comment("Anime102","Never thought that one would be on the list"));
    video4.AddComment(new Comment("Anime103","Watch Serason 2 it's pretty great"));
    video4.AddComment(new Comment("Anime104","Yay! More Anime!"));

     videos.Add(video4);
 
 foreach(var video in videos)
        {
         video.DisplayVideoInfo();   
        }
    }
}