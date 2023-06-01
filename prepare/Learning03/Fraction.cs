using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Defaults fraction to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int wholeNumber)
    {
        _top = wholeNumber;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int wholeNumber)
    {
        _bottom = wholeNumber;
    }

}