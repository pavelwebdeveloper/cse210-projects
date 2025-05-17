using System;
using System.IO;
//using Newtonsoft.Json;
using System.Text.Json;


// Used resources:
// https://medium.com/@ferzia_firdousi/multi-level-nested-json-82d29dd9528
// https://stackoverflow.com/questions/31774795/deserialize-json-from-file-in-c-sharp
// https://code.visualstudio.com/docs/csharp/package-management
// https://medium.com/@Has_San/json-handling-in-c-a-comprehensive-guide-for-developers-0ed233365bf2

class Program
{
    static void CreationOfVideoObjects(List<Video> videos)
    {
        
        Video video1 = new Video("Bortsch soup", "Petro Shevchenko", 45);
        videos.Add(video1);
        Video video2 = new Video("Vareniki", "Oksana Shevchenko", 50);
        videos.Add(video2);
        Video video3 = new Video("Okroshka", "Olia Hapko", 30);
        videos.Add(video3);
    }

    static void AddingCommentsForVideos(List<Video> videos)
    {
        videos[0].AddingComment("Sveta Doleena", "I like Bortsch");
        videos[0].AddingComment("Denis Rooban", "It can be served with salo");
        videos[0].AddingComment("Oleg Redko", "And garlic");
        videos[0].AddingComment("Petro Sagaidachni", "There are so many kinds of Bortsch");

        videos[1].AddingComment("Ivan Zeeto", "It is my favourite dish");
        videos[1].AddingComment("Natalka Poltavka", "They are good with cabbage");
        videos[1].AddingComment("Sergei Hata", "And cottage cheese");

        videos[2].AddingComment("Marina Kutz", "It is so good in summer");
        videos[2].AddingComment("Alex Zuchko", "Yes it is always served cold");
        videos[2].AddingComment("Zeena Tigipko", "I want to cook it tonight");
    }

    static void ShowVideos(List<Video> videos)
    {
        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Console.WriteLine();
        Console.WriteLine("                     YouTube Videos                        ");
        Console.WriteLine();
        CreationOfVideoObjects(videos);
        AddingCommentsForVideos(videos);

        ShowVideos(videos);

    }
}