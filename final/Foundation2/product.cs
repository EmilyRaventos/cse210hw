using System;

public class Product
{
    private string _productName;
    private int _productId;
    private float _price;
    private int _quantity;
    private float _totalPrice;

    Product()
    {

    }
    public float GetTotalPrice()
    {
        return _totalPrice;
    }
}