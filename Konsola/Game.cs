public class Game
{
    private readonly Backend backend;
    private readonly Frontend frontend;

    public Game(int difficultyLevel)
    {
        int minRange, maxRange, maxAttempts;

        switch (difficultyLevel)
        {
            case 1:
                minRange = 1;
                maxRange = 9;
                maxAttempts = 2;
                break;
            case 2:
                minRange = 10;
                maxRange = 99;
                maxAttempts = 5;
                break;
            case 3:
                minRange = 100;
                maxRange = 999;
                maxAttempts = 8;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(difficultyLevel), "Nieprawidłowy poziom trudności.");
        }

        backend = new Backend(minRange, maxRange, maxAttempts);
        frontend = new Frontend();
    }

    public void StartGame()
    {
        Console.WriteLine("Witaj w grze zgadywania liczby!");
        int guess;

        do
        {
            guess = frontend.GetGuess();
        }
        while (!backend.GuessNumber(guess));

        if (frontend.AskForPlayAgain())
        {
            backend.ResetGame(); // Zresetuj grę przed rozpoczęciem nowej rundy
            StartGame();
        }
    }
}