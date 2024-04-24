using System;


string lettergrade = "";
Console.WriteLine("What's your grade");
int grade = int.Parse(Console.ReadLine());
string sign = "";

if (grade >= 90)
{
    lettergrade = "A";
}

else if (grade >= 80)
{
    lettergrade = "B";
}
else if (grade >= 70)
{
    lettergrade = "C";
}
else if (grade >= 60)
{
    lettergrade = "D";
}
else if (grade < 60)
{
    lettergrade = "F";
}

// Get the + or - sign for the grade
if (grade > 60 || grade < 90)
{
    if (grade % 10 >= 7)
    {
        sign = "+";
    }
    
    else if (grade % 10 < 3)
    {
        sign = "-";
    }
}

Console.WriteLine($"Your grade is {lettergrade}{sign}.");
