namespace Math_Game;

internal class Helpers
{
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
}
