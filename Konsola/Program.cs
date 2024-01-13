public class Program
{
    public static void Main()
    {
        do
        {
            Frontend frontend = new Frontend();
            int difficultyLevel = frontend.GetDifficultyLevel();

            Game game = new Game(difficultyLevel);
            game.StartGame();

        } while (true);
    }
}