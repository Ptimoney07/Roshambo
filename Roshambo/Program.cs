// Namespaces organize your code and prevent naming onflicts with other libraries
namespace Roshambo;

// This brings in core system functionality, like the 'Console' class for reading/writing text. 
using System;

// The main container class for out console application.
public class Program
{
    // The Main methof is the exact stating point (entry point) where the computer
    // begins executing your program. 'args' is an array that stores any words or values
    //passed to the program when running it from the terminal.
    static void Main(string[] args)
    {
        // This uses a "Ternary Operator" (condition ? if_true : if_false) as a shorthand
        // for an if-else statement. It checks if a first arguement was typed in the temrinal.
        // if yes, it saves it; if not, it defualts to "Rock".
        var user = args.Length > 0 ? args[0] : "Rock";

        // does the same check for second arguement in the terminal.
        var computer = args.Length > 1 ? args[1] : "Rock";


        Console.WriteLine(DecideWinner(user, computer));
    }


    public static string DecideWinner(string user, string computer)
    {
        if (user == computer) return "Draw";


        if ((user == "Rock" && computer == "Scissors") ||
            (user == "Paper" && computer == "Rock") ||
            (user == "Scissors" && computer == "Paper"))
        {
            return "Win";
        }

        return "Lose";

    }
}

