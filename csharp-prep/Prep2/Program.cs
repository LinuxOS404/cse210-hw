using System;

Console.WriteLine("Please input your percentage here to determine your grade");
string prcent = Console.ReadLine();
int result = int.Parse(prcent);

string grade = "";

if (result >= 90)
{
    grade = "A";
}
else if (result >= 80)
{
    grade = "B";
}

else if (result >= 70)
{
    grade = "C";
}

else if (result >= 60)
{
    grade = "D";
}


else
{
    grade = "F";
}

if (result <= 70)
{

    Console.WriteLine($"Your grade is an:{grade}");
}
if (result <= 70)
{
    Console.WriteLine($"Your grade for this class was an {grade} You have failed this course,you will need to take this course again.");
}
else
{
    Console.WriteLine($"Your grade for this class was an {grade} You have passed this course.");
}
