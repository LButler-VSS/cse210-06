using cse210_06.Game.Casting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Scripting
{
    public class DrawCardAction : Action
    {
        private VideoService videoService;
        
        public DrawCardAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
            List<Card> list = deck.GetDealt();
            int i = 0;

            foreach (Actor actor in list) 
            {
                    i++;

                    Card card = (Card)actor;
                    Body body = card.GetBody();
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    if (i == 1)
                    {
                        Image image = card.GetImage();
                        Point position = body.GetPosition();
                        videoService.DrawImage(image, position);
                        videoService.DrawRectangle(size, pos, Constants.PURPLE, true);
                    }
                    else
                    {
                        videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                        Image image = card.GetImage();
                        Point position = body.GetPosition();
                        videoService.DrawImage(image, position);
                    }
                    
            }
        }
    }
}