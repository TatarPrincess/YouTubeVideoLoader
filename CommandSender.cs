using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideoLoader;

public class CommandSender
{
    Command command;
    public CommandSender(Command command)
    { 
      this.command = command;
    }

    public Task run()
    {
        return command.Execute();
    }
}
