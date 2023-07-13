using System;

class Lectures: Events
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string date, string time, string speaker, int capacity, Address address) // Set activity type, title, description, date, time, and address
    {
        _type = "Lecture";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _speaker = speaker;
        _capacity = capacity;
        _specificInfo = $"Speaker: {_speaker}\nCapacity: {_capacity}";
        _address = address;
    }
}