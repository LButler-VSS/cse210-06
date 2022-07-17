using System.Collections.Generic;
using cse210_06.Game.Casting;
using cse210_06.Game.Services;

namespace cse210_06.Game.Scripting
{
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script)
        {
            videoService.ClearBuffer();
            foreach (Actor actor in cast)
            {
                videoService.DrawActors(wallOne);
                videoService.DrawActors(wallTwo);
                videoService.DrawActor(bikeOne);
                videoService.DrawActor(bikeTwo);
                videoService.DrawActor(scoreOne);
                videoService.DrawActor(scoreTwo);
                videoService.DrawActors(messages);
            }
            videoService.FlushBuffer();
        }
    }
}
