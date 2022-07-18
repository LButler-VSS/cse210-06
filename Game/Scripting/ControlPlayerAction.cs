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

            if (keyboardService.IsKeyDown(Constants.LEFT))
            {
                deck.Deal(1);
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