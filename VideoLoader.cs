using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YouTubeVideoLoader;

public class VideoLoader : Command
{
    public VideoLoader(string url) : base(url) { }
    public async override Task Execute()
    {
        var youtube = new YoutubeClient();

        var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
        var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
        await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
    }
}
