using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class UnloadAssetsAction : Action
    {
        private VideoService videoService;
        
        public UnloadAssetsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.UnloadFonts();
            videoService.UnloadImages();
        }
    }
}