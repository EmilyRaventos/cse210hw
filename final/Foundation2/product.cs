using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;
    private double _totalPrice;

    public Product(string productName, int productId, double price, int quatity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quatity;
    }
    public double GetTotalPrice()
    {
        _totalPrice = _price * _quantity;
        return _totalPrice;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}