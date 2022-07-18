using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class ReleaseDevicesAction : Action
    {
        private VideoService videoService;
        
        public ReleaseDevicesAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            videoService.Release();
        }
    }
}