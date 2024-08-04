namespace Math_Game;

internal class Menu
{
    internal static void ShowMenu()
    {
        Console.Write("Please Enter Your Name: ");
        var name = Console.ReadLine();
        var date = DateTime.UtcNow;
        Console.WriteLine($"Welcome {name} it's {date.AddHours(3)} and this is the Math Game, Are you ready?");
        var gameMode = Helpers.Mode();
        var game = ChooseGame();
        DetermineGame(game, gameMode);

        
    }

    static string ChooseGame()
    {
        Console.WriteLine(@"Please Choose GAME :
A - Addition
S - Substraction
M - Multiplication
D - Division
R - Random Game
Q - Quit Game");
        string? operatrion = Console.ReadLine();
        return operatrion.ToLower();
    }

    static void DetermineGame(string game, string mode)
    {
        switch (game)
        {
            case "a":
                GameEngine.AdditionGame(mode);
                break;
            case "s":
                GameEngine.SubtractionGame(mode);
                break;
            case "m":
                GameEngine.MultiplicationGame(mode);
                break;
            case "d":
                GameEngine.DivisionGame(mode);
                break;
            case "r":
                string modes = "asmd";
                DetermineGame(modes[Random.Shared.Next(0, 4)].ToString(), mode);
                break;
            case "q":
                Console.WriteLine("Good Bye");
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid character, Please try again");
                DetermineGame(ChooseGame(), mode);
                break;
        }
    }
}
