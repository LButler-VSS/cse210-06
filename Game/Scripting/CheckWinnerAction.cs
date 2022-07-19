using System.Collections.Generic;
using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class CheckWinnerAction : Action
    {
        public CheckWinnerAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            List<Card> list = deck.GetDealt();

            if (stats.GetDealerValue() < stats.GetPlayerValue())
            {
                stats.WinBet();
                callback.OnNext(Constants.TRY_AGAIN);
            }
            else if (stats.GetDealerValue() > stats.GetPlayerValue())
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
            else if (stats.GetDealerValue() == stats.GetPlayerValue())
                {
                int bet = stats.GetBet();
                stats.AddPoints(bet);
                stats.SetBet(0);
                callback.OnNext(Constants.TRY_AGAIN);
                }
        }
    }
}