using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicalNumber = randomGenerator.Next(1,20);

        int guess = -1; 

        while (guess != magicalNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicalNumber > guess)
            {
                Console.WriteLine("Guess higher!");
            }

            else if (magicalNumber < guess)
            {
                Console.WriteLine("Guess lower.");
            }

            else
            {
                Console.WriteLine("We have a winner!");
            }
        }
    }
}