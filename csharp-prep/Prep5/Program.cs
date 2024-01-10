using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string usersName = PromptUserName();
        int usersNumber = PromptUserNumber();
        int squaredUserNumber = SquareNumber(usersNumber);
        DisplayResult(usersName, squaredUserNumber);
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?");
            string number = Console.ReadLine();
            int cNumber = int.Parse(number);
            return cNumber;
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"Hello {name}, the square of your favorite number is {squaredNumber}");
        }
    }
}