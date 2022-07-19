using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class ChangeSceneAction : Action
    {
        private KeyboardService keyboardService;
        private string nextScene;

        public ChangeSceneAction(KeyboardService keyboardService, string nextScene)
        {
            this.keyboardService = keyboardService;
            this.nextScene = nextScene;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            if (nextScene == Constants.NEXT_LEVEL)
            {
                if (keyboardService.IsKeyPressed(Constants.ENTER))
                {
                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    stats.RemovePoints(25);
                    stats.SetBet(25);
                    callback.OnNext(nextScene);
                }
            }
            if (nextScene == Constants.IN_PLAY)
            {
                if (keyboardService.IsKeyPressed(Constants.LEFT))
                {
                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    if (stats.GetScore() == 0)
                    {
                        callback.OnNext(nextScene);
                    }
                    else
                    {
                        stats.RemovePoints(25);
                        stats.SetBet(50);
                        callback.OnNext(nextScene);
                    }
                    
                }
                if (keyboardService.IsKeyPressed(Constants.RIGHT))
                {
                    callback.OnNext(nextScene);
                }
            }
        }
    }
}