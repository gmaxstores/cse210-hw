using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("You have unlimited number of guesses to guess the correct number from a range of 1-30. Please use the hints provided. If you wish to quit, kindly reply No");
        string answer;
        
        do
        {
            int guessCount = 1;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int valueNum = 0;
            while (valueNum != number)
            {
                Console.Write("What's the number?");
                string value = Console.ReadLine();
                valueNum = int.Parse(value);
                if (valueNum < number)
                {
                    Console.WriteLine("Guess higher");
                    guessCount = guessCount + 1;
                }
                if (valueNum > number)
                {
                    Console.WriteLine("Guess Lower");
                    guessCount = guessCount + 1;
                }
            }
            Console.WriteLine("You guessed the right number!!!");
            Console.WriteLine($"Number of times you guessed: {guessCount}");
            Console.Write("Do you want to play again?");
            answer = Console.ReadLine();
        } while (answer == "yes");
        Console.WriteLine("Thank you for playing. BYE!!");
    }
}