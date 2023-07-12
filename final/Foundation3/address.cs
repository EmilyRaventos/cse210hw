using System;

public class Address
{
    private string _fullAddress;
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _zip;

    public Address(string streetAddress, string city, string zip, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _zip = zip;
        _state = state;
        _country = country;
    }
    
    public string GetAddressString()
    {
        _fullAddress = $"{_streetAddress}\n{_city} {_state}\n{_country}";
        return _fullAddress;
    }
}