using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int GP = int.Parse(userAnswer); 
        string letter = ""; 

        if (GP >= 90)
        {
            letter = "A";
        }
        else if (GP >= 80)
        {
            letter = "B";
        }
        else if (GP >= 70)
        {
            letter = "C"; 
        }
        else if (GP >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (GP > 70)
        {
            Console.WriteLine("You passed the class!"); 
        }

        else
        {
            Console.WriteLine("Better luck next semester!"); 
        }

    }
}