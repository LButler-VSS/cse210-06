using System;
using System.Collections.Generic;
using System.IO;
using cse210_06.Game.Casting;
using cse210_06.Game.Scripting;
using cse210_06.Game.Services;


namespace cse210_06.Game.Directing
{
    public class SceneManager
    {
        public static KeyboardService KeyboardService = new RaylibKeyboardService();
        public static VideoService VideoService = new RaylibVideoService(Constants.GAME_NAME,
            Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, Constants.BLACK);

        public SceneManager()
        {
        }

        public void PrepareScene(string scene, Cast cast, Script script)
        {
            if (scene == Constants.NEW_GAME)
            {
                PrepareNewGame(cast, script);
            }
            else if (scene == Constants.NEXT_LEVEL)
            {
                PrepareNextLevel(cast, script);
            }
            else if (scene == Constants.TRY_AGAIN)
            {
                PrepareTryAgain(cast, script);
            }
            else if (scene == Constants.IN_PLAY)
            {
                PrepareInPlay(cast, script);
            }
            else if (scene == Constants.GAME_OVER)
            {
                PrepareGameOver(cast, script);
            }
        }

        private void PrepareNewGame(Cast cast, Script script)
        {
            AddStats(cast);
            AddDealerValue(cast);
            AddScore(cast);
            AddPlayerValue(cast);
            AddDeck(cast);
            AddDealt(cast);
            AddDialog(cast, Constants.ENTER_TO_START);

            script.ClearAllActions();
            AddInitActions(script);
            AddLoadActions(script);

            ChangeSceneAction a = new ChangeSceneAction(KeyboardService, Constants.NEXT_LEVEL);
            script.AddAction(Constants.INPUT, a);

            AddOutputActions(script);
            AddUnloadActions(script);
            AddReleaseActions(script);
        }

        /*private void ActivateBall(Cast cast)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            ball.Release();
        }*/

        private void PrepareNextLevel(Cast cast, Script script)
        {
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);
        }

        private void PrepareTryAgain(Cast cast, Script script)
        {
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();
            
            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);
            
            AddUpdateActions(script);
            AddOutputActions(script);
        }

        private void PrepareInPlay(Cast cast, Script script)
        {
            cast.ClearActors(Constants.DIALOG_GROUP);

            script.ClearAllActions();

            ControlPlayerAction action = new ControlPlayerAction(KeyboardService);
            script.AddAction(Constants.INPUT, action);

            AddUpdateActions(script);    
            AddOutputActions(script);
        
        }

        private void PrepareGameOver(Cast cast, Script script)
        {
            AddDialog(cast, Constants.WAS_GOOD_GAME);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.NEW_GAME, 5, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);
        }

        // -----------------------------------------------------------------------------------------
        // casting methods
        // -----------------------------------------------------------------------------------------

        private void AddDeck(Cast cast)
        {
            cast.ClearActors(Constants.CARD_GROUP);

            Deck deck = new Deck();
            string suit = "";
            string symbol = "";
            string filename = "";
            int value = 0;

            Point position = new Point(0, 0);
            Point size = new Point(Constants.CARD_WIDTH, Constants.CARD_HEIGHT);
            Point velocity = new Point(0, 0);

           

            for (int j = 0; j < 5; j++)
            {
                switch (j)
                {
                    case 1:
                        {
                            value = 0;
                            suit = "h";
                            List<string> images = Constants.CARD_IMAGES[suit].GetRange(0, 13);
                            
                            for (int i = 0; i < 13; i++)
                            {
                                filename = images[value];
                                value++;
                                
                                if (value == 1)
                                {
                                    symbol = "Ace";
                                }
                                else if (value == 11)
                                {
                                    symbol = "Jack";
                                }
                                else if (value == 12)
                                {
                                    symbol = "Queen";
                                }
                                else if (value == 13)
                                {
                                    symbol = "King";
                                }
                                else
                                {
                                    symbol = Convert.ToString(value);
                                }
                                Image image = new Image(filename);
                                Body body = new Body(position, size, velocity);
                                Card card = new Card(body, image, symbol, suit, value);
                                deck.AddCard(card);
                            }
                            break;
                        }
                    case 2:
                        {
                            value = 0;
                            suit = "c";
                            List<string> images = Constants.CARD_IMAGES[suit].GetRange(0, 13);

                            for (int i = 0; i < 13; i++)
                            {
                                filename = images[value];
                                value++;
                                if (value == 1)
                                {
                                    symbol = "Ace";
                                }
                                else if (value == 11)
                                {
                                    symbol = "Jack";
                                }
                                else if (value == 12)
                                {
                                    symbol = "Queen";
                                }
                                else if (value == 13)
                                {
                                    symbol = "King";
                                }
                                else
                                {
                                    symbol = Convert.ToString(value);
                                }
                                Image image = new Image(filename);
                                Body body = new Body(position, size, velocity);
                                Card card = new Card(body, image, symbol, suit, value);
                                deck.AddCard(card);
                            }
                            break;
                        }
                    case 3:
                        {
                            value = 0;
                            suit = "s";
                            List<string> images = Constants.CARD_IMAGES[suit].GetRange(0, 13);

                            for (int i = 0; i < 13; i++)
                            {
                                filename = images[value];
                                value++;
                                if (value == 1)
                                {
                                    symbol = "Ace";
                                }
                                else if (value == 11)
                                {
                                    symbol = "Jack";
                                }
                                else if (value == 12)
                                {
                                    symbol = "Queen";
                                }
                                else if (value == 13)
                                {
                                    symbol = "King";
                                }
                                else
                                {
                                    symbol = Convert.ToString(value);
                                }
                                Image image = new Image(filename);
                                Body body = new Body(position, size, velocity);
                                Card card = new Card(body, image, symbol, suit, value);
                                deck.AddCard(card);
                            }
                            break;
                        }
                    case 4:
                        {
                            value = 0;
                            suit = "d";
                            List<string> images = Constants.CARD_IMAGES[suit].GetRange(0, 13);

                            for (int i = 0; i < 13; i++)
                            {
                                filename = images[value];
                                value++;
                                if (value == 1)
                                {
                                    symbol = "Ace";
                                }
                                else if (value == 11)
                                {
                                    symbol = "Jack";
                                }
                                else if (value == 12)
                                {
                                    symbol = "Queen";
                                }
                                else if (value == 13)
                                {
                                    symbol = "King";
                                }
                                else
                                {
                                    symbol = Convert.ToString(value);
                                }
                                Image image = new Image(filename);
                                Body body = new Body(position, size, velocity);
                                Card card = new Card(body, image, symbol, suit, value);
                                deck.AddCard(card);
                            }
                            break;
                        }
                    default:
                        break;
                };
            }

            deck.Shuffle();
            deck.Deal(4);
            cast.AddActor(Constants.DECK_GROUP, deck);
        }

        private void AddDealt(Cast cast) 
        {
            {
                int i = 0;
                int x = Constants.CENTER_LEFT_X - 170;
                int y = Constants.CENTER_TOP_Y - 80;
                Deck deck = (Deck)cast.GetFirstActor(Constants.DECK_GROUP);
                List<Card> list = deck.GetDealt();

                
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


                }

                deck.SetDealt(list);
            }
        }
        private void AddDialog(Cast cast, string message)
        {
            cast.ClearActors(Constants.DIALOG_GROUP);

            Text text = new Text(message, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_CENTER, Constants.WHITE);
            Point position = new Point(Constants.CENTER_X, Constants.CENTER_Y);

            Label label = new Label(text, position);
            cast.AddActor(Constants.DIALOG_GROUP, label);   
        }

        private void AddDealerValue(Cast cast)
        {
            cast.ClearActors(Constants.LEVEL_GROUP);

            Text text = new Text(Constants.LEVEL_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_LEFT, Constants.WHITE);
            Point position = new Point(Constants.HUD_MARGIN, Constants.HUD_MARGIN);

            Label label = new Label(text, position);
            cast.AddActor(Constants.LEVEL_GROUP, label);
        }

        private void AddPlayerValue(Cast cast)
        {
            cast.ClearActors(Constants.LIVES_GROUP);

            Text text = new Text(Constants.LIVES_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_RIGHT, Constants.WHITE);
            Point position = new Point(Constants.SCREEN_WIDTH - Constants.HUD_MARGIN, 
                Constants.HUD_MARGIN);

            Label label = new Label(text, position);
            cast.AddActor(Constants.LIVES_GROUP, label);   
        }

        private void AddScore(Cast cast)
        {
            cast.ClearActors(Constants.SCORE_GROUP);

            Text text = new Text(Constants.SCORE_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_CENTER, Constants.WHITE);
            Point position = new Point(Constants.CENTER_X, Constants.HUD_MARGIN);
            
            Label label = new Label(text, position);
            cast.AddActor(Constants.SCORE_GROUP, label);   
        }

        private void AddStats(Cast cast)
        {
            cast.ClearActors(Constants.STATS_GROUP);
            Stats stats = new Stats();
            cast.AddActor(Constants.STATS_GROUP, stats);
        }

        // -----------------------------------------------------------------------------------------
        // scriptig methods
        // -----------------------------------------------------------------------------------------

        private void AddInitActions(Script script)
        {
            script.AddAction(Constants.INITIALIZE, new InitializeDevicesAction(VideoService));
        }

        private void AddLoadActions(Script script)
        {
            script.AddAction(Constants.LOAD, new LoadAssetsAction(VideoService));
        }

        private void AddOutputActions(Script script)
        {
            script.AddAction(Constants.OUTPUT, new StartDrawingAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawHudAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawCardAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawDialogAction(VideoService));
            script.AddAction(Constants.OUTPUT, new EndDrawingAction(VideoService));
        }

        private void AddUnloadActions(Script script)
        {
            script.AddAction(Constants.UNLOAD, new UnloadAssetsAction(VideoService));
        }

        private void AddReleaseActions(Script script)
        {
            script.AddAction(Constants.RELEASE, new ReleaseDevicesAction(VideoService));
        }

        private void AddUpdateActions(Script script)
        {
            script.AddAction(Constants.UPDATE, new CheckOverAction());     
        }
    }
}