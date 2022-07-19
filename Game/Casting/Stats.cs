namespace cse210_06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Stats : Actor
    {
        private int dealer;
        private int player;
        private int score;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Stats(int dealer = 0, int player = 0, int score = 100, 
                bool debug = false) : base(debug)
        {
            this.dealer = dealer;
            this.player = player;
            this.score = score;
        }

        /// <summary>
        /// Adds one level.
        /// </summary>
        public void SetDealerValue(int dealer)
        {
            this.dealer = dealer;
        }

        /// <summary>
        /// Adds an extra life.
        /// </summary>
        public void SetPlayerValue(int player)
        {
            this.player = player;
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The given points.</param>
        public void AddPoints(int points)
        {
            score += points;
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns>The level.</returns>
        public int GetDealerValue()
        {
            return dealer;
        }

        /// <summary>
        /// Gets the lives.
        /// </summary>
        /// <returns>The lives.</returns>
        public int GetPlayerValue()
        {
            return player;
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <returns>The score.</returns>
        public int GetScore()
        {
            return score;
        }        
    }
}