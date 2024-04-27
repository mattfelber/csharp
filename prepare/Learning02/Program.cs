using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job man = new Job("Software Developer", "EvilCorp", 2019, 2020);
        Job woman = new Job("Alpinist", "BMX", 1998, 1999);
        Console.WriteLine(man._companyName);
        Console.WriteLine(woman._companyName);

}
}