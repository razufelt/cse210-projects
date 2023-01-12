using System;

class Program
{
    static void Main(string[] args)
    {   
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMessage();
        {
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber); 

            DisplayResult(userName, squaredNumber);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: "); 
            string userName = Console.ReadLine(); 
            return userName; 
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: "); 
            int favoriteNumber = int.Parse(Console.ReadLine()); 
            return favoriteNumber; 
        } 

        static int SquareNumber(int favoriteNumber)
        {
            int square = favoriteNumber * favoriteNumber; 
            return square; 
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {square}.");
        }

    }
}