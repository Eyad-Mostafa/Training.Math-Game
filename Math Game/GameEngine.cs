using Math_Game.Models;

namespace Math_Game;

internal class GameEngine
{
    internal static void AdditionGame(string gameMode, int numberOfQuestions)
    {
        int score = 0;
        for (int i = 0; i < numberOfQuestions; i++)
        {
            var numbers = GenerateRandomNumbers(gameMode);
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            Console.Write(firstNumber + " + " + secondNumber + " = ");
            var answer = Console.ReadLine();
            if (int.Parse(answer) == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct answer");
                score++;
                Console.Clear();
            }
            else
            { 
                Console.WriteLine("Invalid answer");
                Console.Clear();
            }
        }
        Helpers.AddToHistory(score, numberOfQuestions, GameType.Addition, gameMode);
        Console.WriteLine($"Game Finished with score {score}/{numberOfQuestions}\n");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
    internal static void SubtractionGame(string gameMode, int numberOfQuestions)
    {
        int score = 0;
        for (int i = 0; i < numberOfQuestions; i++)
        {
            var numbers = GenerateRandomNumbers(gameMode);
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            Console.Write(firstNumber + " - " + secondNumber + " = ");
            var answer = Console.ReadLine();
            if (int.Parse(answer) == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct answer");
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid answer");
                Console.Clear();
            }
        }
        Helpers.AddToHistory(score, numberOfQuestions, GameType.Subtraction, gameMode);
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
    internal static void MultiplicationGame(string gameMode, int numberOfQuestions)
    {
        int score = 0;
        for (int i = 0; i < numberOfQuestions; i++)
        {
            var numbers = GenerateRandomNumbers(gameMode);
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            Console.Write(firstNumber + " x " + secondNumber + " = ");
            var answer = Console.ReadLine();
            if (int.Parse(answer) == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct answer");
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid answer");
                Console.Clear();
            }
        }
        Helpers.AddToHistory(score, numberOfQuestions, GameType.Multiplication, gameMode);
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
    internal static void DivisionGame(string gameMode, int numberOfQuestions)
    {
        int score = 0;
        for (int i = 0; i < numberOfQuestions; i++)
        {
            int firstNumber;
            int secondNumber;
            do
            {
                var numbers = GenerateRandomNumbers(gameMode);
                firstNumber = numbers[0];
                secondNumber = numbers[1];
            } while (firstNumber % secondNumber != 0 || firstNumber == secondNumber);

            Console.Write(firstNumber + " / " + secondNumber + " = ");
            var answer = Console.ReadLine();
            if (int.Parse(answer) == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct answer");
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid answer");
                Console.Clear();
            }
        }
        Helpers.AddToHistory(score, numberOfQuestions,GameType.Division, gameMode);
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
    static int[] GenerateRandomNumbers(string gameMode)
    {
        int firstNumber = 0;
        int secondNumber = 0;
        if (gameMode == "Easy")
        {
            Console.Clear();
            Console.WriteLine($"{gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(1, 30);
            secondNumber = random.Next(1, 30);
        }
        else if (gameMode == "Medium")
        {
            Console.Clear();
            Console.WriteLine($"{gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(30, 150);
            secondNumber = random.Next(30, 150);
        }
        else if (gameMode == "Hard")
        {
            Console.Clear();
            Console.WriteLine($"Be Careful, {gameMode} game mode selected!\n");
            var random = new Random();
            firstNumber = random.Next(150, 2001);
            secondNumber = random.Next(150, 2001);
        }
        return [firstNumber, secondNumber];
    }
}
