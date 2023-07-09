using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUSA;

    Address()
    {

    }
    public bool IsUSA()
    {
        return true;
    }
    public string GetAddressString()
    {
        return _streetAddress;
    }
}