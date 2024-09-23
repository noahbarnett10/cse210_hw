using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        do
        {
            Console.Write("Enter a number: ");
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);
            numbers.Add(number);
        } while (number != 0);

        float sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / (numbers.Count - 1);
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int num in numbers) 
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is {max}");


    }
}