using System;

public class Address
{
    private string _fullAddress;
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUSA;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
        return false;
        }
    }
    public string GetAddressString()
    {
        _fullAddress = $"{_streetAddress}\n{_city} {_state}\n{_country}";
        return _fullAddress;
    }
}