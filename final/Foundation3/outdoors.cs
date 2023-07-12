using System;

class Outdoors: Events
{
    private string _weather;
    public Outdoors(string title, string description, string date, string time, string weather, Address address) // Set activity type, title, description, date, time, and address
    {
        _type = "Outdoor";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _weather = weather;
        _specificInfo = $"Weather: {weather}";
        _address = address;
    }
}