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
    video2.AddComment(new Comment("Anime101","Not better the that one I saw last week"));
    video2.AddComment(new Comment("Anime102","these lists are strings"));
    video2.AddComment(new Comment("Anime103","Can the pls get a season 3"));
    video2.AddComment(new Comment("Anime104","Why can't they choose good ones"));
    
    videos.Add(video2);
    
    Video video3 = new Video("Best Anime of 2025","AnimeCity",330);
    video3.AddComment(new Comment("Anime101","Added one to my watchllist"));
    video3.AddComment(new Comment("Anime102","tbh I didn't know that was out yet"));
    video3.AddComment(new Comment("Anime103","Watch Season 2 it's pretty great"));
    video3.AddComment(new Comment("Anime104","Goodbye good nights sleep!"));

    videos.Add(video3);

    Video video4 = new Video("Best Anime of 2025","AnimeCity",110);
    video4.AddComment(new Comment("Anime101","Ugh I don't like the MC"));
    video4.AddComment(new Comment("Anime102","More Action ones pls"));
    video4.AddComment(new Comment("Anime103","I slept through it."));
    video4.AddComment(new Comment("Anime104","zzzzzzzz"));

     videos.Add(video4);
 
 foreach(var video in videos)
        {
         video.DisplayVideoInfo();   
        }
    }
}