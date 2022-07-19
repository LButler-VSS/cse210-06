using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class ControlPlayerAction : Action
    {
        private KeyboardService keyboardService;

        public ControlPlayerAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);

            if (keyboardService.IsKeyPressed(Constants.UP))
            {
                deck.Deal(1);
                callback.OnNext(Constants.IN_PLAY);
            }
            if (keyboardService.IsKeyPressed(Constants.DOWN))
            {
                script.AddAction(Constants.UPDATE, new CheckFinalValuesAction());
                script.AddAction(Constants.UPDATE, new CheckWinnerAction());
            }
        }
    }
}