using Math_Game.Models;
namespace Math_Game;

internal class Helpers
{
    static List<Game> gameHistory = new();
    internal static string Mode()
    {
        Console.WriteLine("Choose Game Mode :");
        Console.WriteLine("Easy (Default) - Medium - Hard");
        string? gameMode = Console.ReadLine();
        
        switch (gameMode.ToLower())
        {
            case "easy":
                return "Easy";
            case "medium":
                return "Medium";
            case "hard":
                return "Hard";
            default:
                Console.Clear();
                Console.WriteLine("Invalid Mode, Please try again:\n");
                return Mode();
        }
    }

    internal static void AddToHistory(int score, int numberOfQuestions, GameType gameType, string gameMode)
    {
        gameHistory.Add(new Game
        {
            DateTime = DateTime.UtcNow.AddHours(3),
            Score = score,
            NumberOfQuestions = numberOfQuestions,
            Type = gameType,
            GameMode = gameMode
        });
    }

    internal static void ShowHistory()
    {
        Console.Clear();
        Console.WriteLine("History: ");
        foreach (var history in gameHistory)
        {
            Console.WriteLine($"{history.DateTime} - {history.GameMode} - {history.Type} - {history.Score}/{history.NumberOfQuestions}");
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
}
