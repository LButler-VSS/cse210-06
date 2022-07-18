using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class InitializeDevicesAction : Action
    {
        private VideoService videoService;
        
        public InitializeDevicesAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.Initialize();
        }
    }
}