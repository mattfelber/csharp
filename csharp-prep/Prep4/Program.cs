using System;
using System.Security.Cryptography.X509Certificates;
/*
Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int response;
        List<int> responseList = new List<int>();
        bool isValidInput;
        int sum = 0;
        float avg;
        int largest = 0;

        do
        {
            Console.WriteLine("Type a number");

            // Assigns true only if an integer is entered
            isValidInput = int.TryParse(Console.ReadLine(), out response); 
            responseList.Add(response);
            
            
        
        if (!isValidInput)
            {
                Console.WriteLine("Please enter a valid number.");
            }

        } while (!isValidInput || response != 0); 

            foreach (int item in responseList)
    {
        sum += item;
        
        if (item>largest){
            largest = item;
        }

    }
    
    avg = (float)sum / responseList.Count();


    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {avg}");
    Console.WriteLine($"Largest: {largest}");

    }


}