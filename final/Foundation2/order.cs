using System;

public class Order
{
    private List<Product> _listOfProduct;
    private Customer _customer;
    private float _totalCost;
    private string _packingLabel;
    private string _shippingLabel;

    Order()
    {

    }
    public void DisplayOrder()
    {

    }
    public float CalculateShippingCost()
    {
        return _totalCost;
    }
    public float CalculateTotalCost()
    {
        return _totalCost;
    }
    public string GetPackingLabel()
    {
        return _packingLabel;
    }
    public string GetShippingLabel()
    {
        return _shippingLabel;
    }
}