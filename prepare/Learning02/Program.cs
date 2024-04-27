using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job = new Job("Software Developer", "EvilCorp", 2016, 2019);
        
        string company = job._companyName;
        Console.WriteLine(company);
}
}