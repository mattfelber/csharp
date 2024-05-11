using System;

class Program


{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine("Scripture!");

        Fraction fraction = new Fraction();
        Console.WriteLine("Upper: ");
        int upper = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lower: ");
        int lower = Convert.ToInt32(Console.ReadLine());
        
        fraction.SetUpper(upper);
        int getUpper = fraction.GetUpper();
        Console.WriteLine(getUpper);

        fraction.SetLower(lower);
        int getLower = fraction.GetLower();
        Console.WriteLine(getLower);

        string fractionString = fraction.GetFractionString();
        double decimalValue = fraction.GetDecimalValue();
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);

    }




}