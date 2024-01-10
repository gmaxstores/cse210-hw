using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> newNumbers = new List<int>();
        int sumOfNumbers = 0;
        string input;
        do
        {
            Console.Write("Input a number. Type 0 when you are done");
            input = Console.ReadLine();
            int inputNum = int.Parse(input);
            numbers.Add(inputNum);
        } while (input != "0");
        int count = -1;
        int maxNum = numbers[0];
        foreach (int number in numbers)
        {
            sumOfNumbers = number + sumOfNumbers;
            count = count + 1;
            if (number > maxNum)
            {
                maxNum = number;
            }
            if (number > 0)
            {
                newNumbers.Add(number);
            }
        }
        int firstValue = newNumbers[0];
        Console.WriteLine(firstValue);
        Console.WriteLine($"Total: {sumOfNumbers}");
        float avg = ((float)sumOfNumbers/count);
        Console.WriteLine($"Average: {avg} and maximum number: {maxNum}");
        numbers.Remove(0);
        numbers.Sort();
        foreach (int a in numbers)
        {
            Console.WriteLine(a);
        }
    }
}