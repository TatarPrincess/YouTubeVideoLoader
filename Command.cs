using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideoLoader;

public abstract class Command
{
    public string ?url;
    public Command(string url)
    { 
      this.url = url;
    }
    public abstract Task Execute();
}
