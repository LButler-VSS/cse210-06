using System.Collections.Generic;
using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class CheckFinalValuesAction : Action
    {
        public CheckFinalValuesAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            List<Card> list = deck.GetDealt();

            int dealervalue = 0;
            int playervalue = 0;

            foreach (Actor actor in list)
            {
                Card card = (Card)actor;
                Body body = card.GetBody();
                Point point = body.GetPosition();
                int y = point.GetY();

                if (y < Constants.CENTER_Y)
                {
                    if (card.GetValue() > 1)
                    {
                        dealervalue += card.GetValue();
                    }
                    else
                    {
                        dealervalue += 11;
                    }
                }
                else
                {
                    if (card.GetValue() > 1)
                    {
                        playervalue += card.GetValue();
                    }
                    else
                    {
                        playervalue += 11;
                    }
                }
            }

            stats.SetDealerValue(dealervalue);
            stats.SetPlayerValue(playervalue);
        }
    }
}