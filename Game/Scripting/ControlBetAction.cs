using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class ControlBetAction : Action
    {
        private KeyboardService keyboardService;

        public ControlBetAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {


            if (keyboardService.IsKeyDown(Constants.LEFT))
            {

            }
            else if (keyboardService.IsKeyDown(Constants.RIGHT))
            {
                
            }
            else
            {

            }
        }
    }
}