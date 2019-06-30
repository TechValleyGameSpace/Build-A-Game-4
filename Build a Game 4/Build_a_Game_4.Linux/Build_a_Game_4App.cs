using Xenko.Engine;

namespace Build_a_Game_4.Linux
{
    class Build_a_Game_4App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
