using System.Collections.Generic;
using cse210_06.Game.Casting;


namespace cse210_06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "BlackJack";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_LEFT_X = SCREEN_WIDTH / 4;
        public static int CENTER_RIGHT_X = SCREEN_WIDTH / 4 * 3;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;
        public static int CENTER_TOP_Y = SCREEN_HEIGHT / 4;
        public static int CENTER_BOTTOM_Y = SCREEN_HEIGHT / 4 * 3;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string UP = "up";
        public static string DOWN = "down";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string BET_GROUP = "bet";
        public static string LEVEL_FORMAT = "DEALER HAND VALUE: {0}";
        public static string LIVES_FORMAT = "YOUR HAND VALUE: {0}";
        public static string SCORE_FORMAT = "POINTS: {0}";
        public static string BET_FORMAT = "BET: {0}";

        // DECK
        public static string CARD_GROUP = "card";
        public static string DECK_GROUP = "deck";

        public static Dictionary<string, List<string>> CARD_IMAGES
            = new Dictionary<string, List<string>>() {
                { "c", new List<string>() {
                    "Assets/Images/CardFace/ace_of_clubs.png",
                    "Assets/Images/CardFace/2_of_clubs.png",
                    "Assets/Images/CardFace/3_of_clubs.png",
                    "Assets/Images/CardFace/4_of_clubs.png",
                    "Assets/Images/CardFace/5_of_clubs.png",
                    "Assets/Images/CardFace/6_of_clubs.png",
                    "Assets/Images/CardFace/7_of_clubs.png",
                    "Assets/Images/CardFace/8_of_clubs.png",
                    "Assets/Images/CardFace/9_of_clubs.png",
                    "Assets/Images/CardFace/10_of_clubs.png",
                    "Assets/Images/CardFace/jack_of_clubs2.png",
                    "Assets/Images/CardFace/queen_of_clubs2.png",
                    "Assets/Images/CardFace/king_of_clubs2.png"
                } },
                { "d", new List<string>() {
                    "Assets/Images/CardFace/ace_of_diamonds.png",
                    "Assets/Images/CardFace/2_of_diamonds.png",
                    "Assets/Images/CardFace/3_of_diamonds.png",
                    "Assets/Images/CardFace/4_of_diamonds.png",
                    "Assets/Images/CardFace/5_of_diamonds.png",
                    "Assets/Images/CardFace/6_of_diamonds.png",
                    "Assets/Images/CardFace/7_of_diamonds.png",
                    "Assets/Images/CardFace/8_of_diamonds.png",
                    "Assets/Images/CardFace/9_of_diamonds.png",
                    "Assets/Images/CardFace/10_of_diamonds.png",
                    "Assets/Images/CardFace/jack_of_diamonds2.png",
                    "Assets/Images/CardFace/queen_of_diamonds2.png",
                    "Assets/Images/CardFace/king_of_diamonds2.png"
                } },
                { "h", new List<string>() {
                    "Assets/Images/CardFace/ace_of_hearts.png",
                    "Assets/Images/CardFace/2_of_hearts.png",
                    "Assets/Images/CardFace/3_of_hearts.png",
                    "Assets/Images/CardFace/4_of_hearts.png",
                    "Assets/Images/CardFace/5_of_hearts.png",
                    "Assets/Images/CardFace/6_of_hearts.png",
                    "Assets/Images/CardFace/7_of_hearts.png",
                    "Assets/Images/CardFace/8_of_hearts.png",
                    "Assets/Images/CardFace/9_of_hearts.png",
                    "Assets/Images/CardFace/10_of_hearts.png",
                    "Assets/Images/CardFace/jack_of_hearts2.png",
                    "Assets/Images/CardFace/queen_of_hearts2.png",
                    "Assets/Images/CardFace/king_of_hearts2.png"
                } },
                { "s", new List<string>() {
                    "Assets/Images/CardFace/ace_of_spades.png",
                    "Assets/Images/CardFace/2_of_spades.png",
                    "Assets/Images/CardFace/3_of_spades.png",
                    "Assets/Images/CardFace/4_of_spades.png",
                    "Assets/Images/CardFace/5_of_spades.png",
                    "Assets/Images/CardFace/6_of_spades.png",
                    "Assets/Images/CardFace/7_of_spades.png",
                    "Assets/Images/CardFace/8_of_spades.png",
                    "Assets/Images/CardFace/9_of_spades.png",
                    "Assets/Images/CardFace/10_of_spades.png",
                    "Assets/Images/CardFace/jack_of_spades2.png",
                    "Assets/Images/CardFace/queen_of_spades2.png",
                    "Assets/Images/CardFace/king_of_spades2.png"
                } }
        };

        public static int CARD_WIDTH = 150;
        public static int CARD_HEIGHT = 216;

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string HIT = "HIT? UP = YES : DOWN = NO";
        public static string BET_INCREASE = "INCREASE BET? LEFT = YES : RIGHT = NO";
        public static string ROUND_OVER = "ROUND OVER";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}