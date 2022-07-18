using System;

namespace cse210_06.Game.Casting
{
    public class Score : Actor
    {
        private int points = 0;

        public Score(bool debug = false) : base(debug)
        {
            AddPoints(0);
        }

        public void AddPoints(int points)
        {
            this.points += points;
        }
    }
}
