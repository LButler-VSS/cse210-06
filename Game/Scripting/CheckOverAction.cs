using System.Collections.Generic;
using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class CheckOverAction : Action
    {
        public CheckOverAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            List<Card> list = deck.GetDealt();

            if ((list[0].GetValue() == 10 & list[1].GetValue() == 1) | (list[0].GetValue() == 1 & list[1].GetValue() == 10))
            {
                stats.LoseBet();
                if (stats.GetScore() == 0)
                {
                    stats.SetDealerValue(0);
                    stats.SetPlayerValue(0);
                    stats.AddPoints(100);
                    callback.OnNext(Constants.GAME_OVER);
                }   
                else
                    callback.OnNext(Constants.TRY_AGAIN);
            }
            if ((list[2].GetValue() == 10 & list[3].GetValue() == 1) | (list[2].GetValue() == 1 & list[3].GetValue() == 10))
            {
                stats.WinBet();
                callback.OnNext(Constants.TRY_AGAIN);
            }

            if (stats.GetDealerValue() > 21)
            {
                stats.WinBet();
                callback.OnNext(Constants.TRY_AGAIN);
            }
            if (stats.GetPlayerValue() > 21)
            {
                script.AddAction(Constants.UPDATE, new CheckFinalValuesAction());
                stats.LoseBet();
                if (stats.GetScore() == 0)
                {
                    stats.SetDealerValue(0);
                    stats.SetPlayerValue(0);
                    stats.AddPoints(100);
                    callback.OnNext(Constants.GAME_OVER);
                } 
                else
                    callback.OnNext(Constants.TRY_AGAIN);
            }

        }
    }
}