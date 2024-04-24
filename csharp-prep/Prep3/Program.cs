using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        // Number guessing

        Random randomGen = new Random();
        int randomNumber = randomGen.Next(0,10);

        int response;
        do
        {
            Console.WriteLine("Guess the number");
            response = int.Parse(Console.ReadLine());

        } while (response != randomNumber);
    }
}