public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string Title { get { return title; } }
    public string Description { get { return description; } }
    public DateTime Date { get { return date; } }
    public string Time { get { return time; } }
    public Address Address { get { return address; } }

    public virtual string GetStandardDetails()
    {
        return $"{Title}\nDescription: {Description}\nDate: {date:yyyy-MM-dd}\nTime: {time}\nAddress:\n{address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name} - {Title}\nDate: {date:yyyy-MM-dd}";
    }
}
