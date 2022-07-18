using Raylib_cs;
using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class EndDrawingAction : Action
    {
        private VideoService videoService;
        
        public EndDrawingAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.FlushBuffer();
        }
    }
}