using System;
using System.Collections.Generic;

class Program
{
static void Main()
{
    RunProgram();
}

static void RunProgram()
{
 Console.WriteLine("Welcome to the program!");


Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();

Console.WriteLine("Please enter your favorite number:");

double Favnum = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the year you were born:");
int birthYear = int.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

double squareNum = Math.Sqrt(Favnum);

Console.WriteLine(name + " The square of your number is " + squareNum);

Console.WriteLine(name +" You will turn " + age + " this year.");
}
}