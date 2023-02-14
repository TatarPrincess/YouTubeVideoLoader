using YouTubeVideoLoader;

Command videoInfogetter = new VideoInfoGetter(@"https://youtube.com/shorts/zrQ_kiqd2a4?si=EnSIkaIECMiOmarE");
CommandSender sender = new CommandSender(videoInfogetter);
sender.run().Wait();

Command videoLoader = new VideoLoader(@"https://youtube.com/shorts/zrQ_kiqd2a4?si=EnSIkaIECMiOmarE");
sender = new CommandSender(videoLoader);
sender.run().Wait();

