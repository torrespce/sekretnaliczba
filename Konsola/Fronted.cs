public class Frontend
{
    public int GetDifficultyLevel()
    {
        Console.WriteLine("Wybierz poziom trudności:");
        Console.WriteLine("1. Łatwy");
        Console.WriteLine("2. Średni");
        Console.WriteLine("3. Trudny");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Nieprawidłowy wybór. Wybierz jeszcze raz.");
        }

        return choice;
    }

    public int GetGuess()
    {
        Console.Write("Podaj swoją liczbę: ");
        int guess;
        while (!int.TryParse(Console.ReadLine(), out guess))
        {
            Console.WriteLine("Nieprawidłowy format liczby. Podaj liczbę jeszcze raz.");
        }

        return guess;
    }

    public bool AskForPlayAgain()
    {
        Console.Write("Czy chcesz zagrać ponownie? (T/N): ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        return choice == 'T';
    }
}