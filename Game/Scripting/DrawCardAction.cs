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
            int x = Constants.CENTER_LEFT_X - 170;
            int y = Constants.CENTER_TOP_Y - 80;


            foreach (Actor actor in list) 
            {
                i++;
                Card card = (Card)actor;
                Point point = new Point(x, y);
                Body body = card.GetBody();
                body.SetPosition(point);
                    
                if (i == 2)
                {
                    x = Constants.CENTER_LEFT_X - 170;
                    y = Constants.CENTER_BOTTOM_Y - 120;
                }
                else
                {
                    x += 110;
                }

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