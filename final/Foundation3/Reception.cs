public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public string RSVPEmail { get { return rsvpEmail; } }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {rsvpEmail}";
    }
}
