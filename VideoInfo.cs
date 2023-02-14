using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideoLoader;

public class VideoInfo
{
    public string name;
    public string description;

    public VideoInfo(string name, string description)
    {
        this.name = name;
        this.description = description; 
    }
}
