public class Backend
{
    private readonly Random random = new Random();
    private int secretNumber;
    private int attemptsLeft;

    public Backend(int minRange, int maxRange, int maxAttempts)
    {
        secretNumber = random.Next(minRange, maxRange + 1);
        attemptsLeft = maxAttempts;
    }

    public bool GuessNumber(int guess)
    {
        attemptsLeft--;

        if (guess == secretNumber)
        {
            Console.WriteLine("Gratulacje! Zgadłeś liczbę!");
            return true;
        }
        else
        {
            Console.WriteLine($"Nieprawidłowa liczba. Pozostało prób: {attemptsLeft}");

            if (attemptsLeft == 0)
            {
                Console.WriteLine($"Przegrałeś. Sekretna liczba to: {secretNumber}");
            }

            return false;
        }
    }
}
