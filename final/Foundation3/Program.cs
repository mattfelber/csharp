using System;

public class Program
{
    static void Main(string[] args)
    {
        // addresses
        Address address1 = new Address("1 Life", "Oncherio", "CA", "USA");
        Address address2 = new Address("2 Pac Rd", "Compton", "Ontario", "Canada");
        Address address3 = new Address("Ali Baba", "Columbus", "Ohio", "USA");


        // events
        Event lecture = new Lecture(
            "Machine Learning without a Diploma",
            "Acquire PhD level knowledge in 3 hours",
            DateTime.Parse("2024-06-02 17:00"),
            "5:00 PM",
            address1,
            "Hodl.Pharaoh@yahoo.com",
            50
        );

        Event reception = new Reception(
            "Company Retreat",
            "Celebrate the company 5th year anniversary",
            DateTime.Parse("2024-12-20 19:00"),
            "7:00 PM",
            address2,
            "jackpot@phishing.com"
        );

        Event gathering = new OutdoorGathering(
            "National Alligator Day",
            "Join us for a fun alligator research day",
            DateTime.Parse("2024-06-02 11:00"),
            "11:00 AM",
            address3,
            "wilma@usa.mil"
        );

        // info for each event

        Console.WriteLine("Lecture Details");
        //Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception");
        //Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Details");
        //Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}
