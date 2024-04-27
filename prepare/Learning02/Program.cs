using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job man = new Job();
        Job woman = new Job();

        man._jobTitle = "Developer";
        man._companyName = "Sinqia";
        man._startYear = 2024;
        man._endYear = 2026;
        woman._jobTitle = "Botanist";
        woman._companyName = "Fleur";
        woman._startYear = 1999;
        woman._endYear = 2000;

        Console.WriteLine(man._companyName);
        Console.WriteLine(woman._companyName);
        man.DisplayJobDetails();
        woman.DisplayJobDetails();


        Resume oneResume = new Resume();
        oneResume._name = "Templeton";

        oneResume._jobList.Add(man);
        oneResume._jobList.Add(woman);

        Console.WriteLine("Displaying the first job's title:");
        Console.WriteLine(oneResume._jobList[0]._jobTitle);

        Console.WriteLine("Displaying the name and all the jobs in one line:");
        oneResume.DisplayDetails();


}       
}