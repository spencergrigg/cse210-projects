using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();    
        
        int number = 1;
        int sum = 0;
        int max = 0;

        while (number != 0)
        {
            Console.Write("Please enter a number (Enter 0 to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int item in numbers)
        {
            sum += item;
            if (max < item)
            {
                max = item;
            }
        }
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}