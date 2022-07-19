using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class DrawFirstCardAction : Action
    {
        private VideoService videoService;
        
        public DrawFirstCardAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
            List<Card> list = deck.GetDealt();
            
            Card card = list[0];
            Body body = card.GetBody();
            Image image = card.GetImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);

            Card card2 = list[1];
            Body body2 = card2.GetBody();
            Image image2 = card2.GetImage();
            Point position2 = body2.GetPosition();
            videoService.DrawImage(image2, position2);
                
        }
    }
}