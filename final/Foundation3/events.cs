using System;

class Events
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _specificInfo;
    protected string _type;

    public Events() 
    {
        // Keep this constructor empty and use the child classes to assign values to protected variables.
    }

    public string GenerateStandard()
    {
        string standard = $"{_title} - {_description}\nDate: {_date} {_time}\nAddress:{_address.GetAddressString()}\n";
        return standard;
    }

    public string GenerateFull()
    {
        string full = $"Event Type: {_type}\n{_title} - {_description}\nDate: {_date} {_time}\nAddress:{_address.GetAddressString()}\n{_specificInfo}\n";
        return full;
    }

    public string GenerateShort()
    {
        string small = $"Event Type: {_type}\n{_title} - {_date}\n";
        return small;
    }

    public void DisplayAllDescriptions()
    {
        Console.WriteLine($"Standard Description\n{GenerateStandard()}");
        Console.WriteLine($"Full Description\n{GenerateFull()}");
        Console.WriteLine($"Short Description\n{GenerateShort()}");
    }
}