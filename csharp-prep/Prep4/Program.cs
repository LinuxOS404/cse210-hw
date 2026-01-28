using System;
using System.Collections.Generic;


Console.WriteLine("Enter a list of numbers, type 0 when finished!");


List<int> numbers = new List<int>();
int input;


{
    Console.WriteLine("Enter number:");
    do
    {

        Console.Write("Enter a number (0 to stop): ");
        input = int.Parse(Console.ReadLine());

    if (input != 0)
    {
        numbers.Add(input);
    }

} while (input != 0);

int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}

double average = (double)sum / numbers.Count;
int max = numbers[0];

foreach (int num in numbers)
{
    if (num > max)
    {
        max = num;
    }
}

Console.WriteLine($"The Sum is: {sum}");
Console.WriteLine($" TheAverage is: {average}");
Console.WriteLine($"The Largest number is: {max}");
}