using System;
using System.Text.RegularExpressions;

namespace MarsRovers
{

    class Program
    {

        static string CurPos;
        static string Instructions;
        static bool IsValid = true;

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(args);

            }

        }

        private static bool MainMenu(string[] args)
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO MARS ROVERS");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("Instructions:");
            Console.WriteLine("-------------");
            Console.WriteLine("A rover’s current position and heading are represented by a triple X Y Z");
            Console.WriteLine("consisting of its current grid position X Y plus a letter Z corresponding to");
            Console.WriteLine("one of the four cardinal compass points, N E S W");
            Console.WriteLine();
            Console.WriteLine("Possible instruction letters are L, R, and M.L and R instruct the rover to turn 90 degrees ");      
            Console.WriteLine("left or right, respectively(without moving from its current spot), while M instructs");
            Console.WriteLine("the rover to move forward one grid point along its current heading.");
            Console.WriteLine();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Set rover's current position");
            Console.WriteLine("2) Instruct rover to move to a new position");
            Console.WriteLine("3) Calculate new position");

            if (!string.IsNullOrEmpty(CurPos))
            {
                Console.WriteLine(" - Current Position: " + CurPos);
            }

            if (!string.IsNullOrEmpty(Instructions))
            {
                Console.WriteLine(" - Instructions: " + Instructions);
            }

            if(!IsValid)
            {
                Console.WriteLine("**There is an error in the current position or instructions, please read the General Instructions above.**");
            }

            Console.WriteLine("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("\r\nInsert current position (i.e. 11N) and press Enter: ");
                    CurPos = Console.ReadLine().ToUpper();
                    IsValid = Regex.Match(CurPos, "^[(0-9)][(0-9)][NSEW]$").Success;
                    return true;
                case "2":
                    Console.Write("\r\nInsert instructions (i.e. RMMLM) and press Enter: ");
                    Instructions = Console.ReadLine().ToUpper();
                    IsValid = Regex.Match(Instructions, "^[RLM]+$").Success;
                    return true;
                case "3":
                    
                    if (!String.IsNullOrEmpty(CurPos) && !String.IsNullOrEmpty(CurPos) && IsValid)
                    {
                        Rover rover = new(CurPos, Instructions);
                        Console.WriteLine("The new position is: " + rover.calculateNewPosition());
                    }

                    Console.ReadLine();
                    return true;
                default:
                    Console.WriteLine("Back to Menu");
                    return true;
            }
        }
    }


}
