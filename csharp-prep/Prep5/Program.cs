using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        string name = PromptUserName();
        double squarenumber = SquareNumber();
        DisplayResult(name, squarenumber);
    }
    

/// DisplayWelcome - Displays the message, "Welcome to the Program!"
    static string DisplayWelcome()
    {
        string Welcome = "Welcome to the Program!";
        return Welcome;

    }


// PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.WriteLine("Type your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Output: {name}");
        return name;
        
    }


// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.WriteLine("Type your favorite number: ");
        string input = Console.ReadLine();
        int favoriteNumber = int.Parse(input);
        Console.Write($"Output: {favoriteNumber}");
        return favoriteNumber;
        
    }


// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static double SquareNumber()
    {
        Console.WriteLine("Get squared number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int squarenumber = number * number;
        Console.Write($"Output: {squarenumber}");
        return squarenumber;
    }


// DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, double squarenumber)
    {
        Console.WriteLine($"Name: {name}, Square: {squarenumber}");
    }
}