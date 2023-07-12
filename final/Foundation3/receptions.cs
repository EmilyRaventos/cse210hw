using System;

class Receptions: Events
{
    private bool _didRSVP;
    private string _rsvpEmail;
    public Receptions(string title, string description, string date, string time, string rsvpEmail, Address address) // Set activity type, title, description, date, time, and address
    {
        _type = "Reception";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _rsvpEmail = rsvpEmail;
        _specificInfo = $"RSVP Email: {_rsvpEmail}";
        _address = address;
    }
}