namespace Math_Game;

internal class GameEngine
{
    internal static void AdditionGame(string gameMode)
    {
        var numbers = GenerateRandomNumbers(gameMode);
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];

    }
    internal static void SubtractionGame(string gameMode)
    {
        var numbers = GenerateRandomNumbers(gameMode);
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];
    }
    internal static void MultiplicationGame(string gameMode)
    {
        var numbers = GenerateRandomNumbers(gameMode);
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];
    }
    internal static void DivisionGame(string gameMode)
    {
        var numbers = GenerateRandomNumbers(gameMode);
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];
    }
    static int[] GenerateRandomNumbers(string gameMode)
    {
        int firstNumber = 0;
        int secondNumber = 0;
        if (gameMode == "Easy")
        {
            Console.WriteLine($"{gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(1, 30);
            secondNumber = random.Next(1, 30);
        }
        else if (gameMode == "Medium")
        {
            Console.WriteLine($"{gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(30, 100);
            secondNumber = random.Next(30, 100);
        }
        else if (gameMode == "Hard")
        {
            Console.WriteLine($"Be Careful, {gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(100, 1001);
            secondNumber = random.Next(100, 1001);
        }
        return new int[] { firstNumber, secondNumber };
    }
}
