using System;
using cse210_06.Game.Directing;

namespace cse210_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.StartGame();
        }
    }
}