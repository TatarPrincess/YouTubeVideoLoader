using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeVideoLoader;

public class VideoInfoGetter : Command
{
    public VideoInfo ?info;

    public VideoInfoGetter(string url) : base(url) { }

    public async override Task Execute()
    {
        YoutubeClient youtubeClient = new YoutubeClient();
        
        try
        {
            var video = await youtubeClient.Videos.GetAsync(url);
            info = new VideoInfo(video.Title, video.Description);
            Console.WriteLine($"Название:  {info.name}, \t Описание: {info.description}");
        }
        catch (Exception ex) 
        {
          Console.WriteLine($"Что-то пошло не так: {ex}" );
        }
             
    }
}
