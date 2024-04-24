using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Random randomGen = new Random();
        int randomNumber = randomGen.Next(0,10);

        int response;
        bool isValidInput; // track input validity

        do
        {
            Console.WriteLine("Guess the number");

            // Assigns true only if an integer is entered
            isValidInput = int.TryParse(Console.ReadLine(), out response);  
            
        
        if (!isValidInput)
            {
                Console.WriteLine("Please enter a valid integer.");
            }

        } while (!isValidInput || response != randomNumber); 
        
        if (response == randomNumber)
        {
            Console.WriteLine($"You guessed it! Number {randomNumber}.");
        }
    }
}