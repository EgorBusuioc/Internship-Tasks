using System.Text.RegularExpressions;

namespace Task_Nr1;

    //Create a method to determine the color of any chess board cell by its notation:
    
    //Example:
    //Input: a1
    //Result: Black

class ChessTable
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Write down position");
            string userInput = Console.ReadLine();
            Console.WriteLine("You wrote - " + userInput);

            Console.WriteLine("Result: " + DefineColorOfChessTable(userInput));
        }
        catch
        {
            Console.WriteLine("Exception was trowed! You must input a correct string like 'a8'");
        }
    }

    public static string DefineColorOfChessTable(string position)
    {
        position = position.ToLower();
        if (!Regex.IsMatch(position, "^[a-h][1-8]$"))
        {
            throw new ArgumentOutOfRangeException(position);
        }

        if (position[0] + position[1] % 2 == 1)
        {
            return "White";
        }
        
        return "Black";
    }
}
