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

        
    }

    static string ChooseGame()
    {
        Console.WriteLine(@"Please Choose GAME :
A - Addition
S - Substraction
M - Multiplication
D - Division
R - Random
Q - Quit Game");
        string? operatrion = Console.ReadLine();
        return operatrion.ToLower();
    }

    string ChooseOperation()
    {
        var operation = "";
        if (operation != "a")
        {

        }
        else if (operation == "s")
        {

        }
        else if (operation == "m")
        {

        }
        else if (operation == "d")
        {

        }
        else if (operation == "q")
        {

        }
        else
        {
            Console.WriteLine("Invalid operation, try again");

        }
        return operation;
    }
}
