using System;

public class Order
{
    private List<Product> _listOfProducts;
    private Customer _customer;
    private double _totalCost;
    private double _shippingCost;
    private string _packingLabel;
    private string _shippingLabel;
    private string _receipt;

    public Order(Customer customer)
    {
        List<Product> listOfProduct = new List<Product>();
        _listOfProducts = listOfProduct;
        _customer = customer;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Packing Label: \n{_packingLabel}");
        Console.WriteLine($"Shipping Label: \n{_shippingLabel}");
        Console.WriteLine($"Itemized Reciept: \n{_receipt}\n");
        Console.WriteLine($"Total Cost: ${Math.Round(_totalCost,2)}\n");
    }

    public void AddProduct(Product product)
    {
        _listOfProducts.Add(product);
    }

    public List<Product> GetListOfProducts()
    {
        return _listOfProducts;
    }

    public double CalculateShippingCost(Customer customer)
    {
        if (customer.FromUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        
        return _shippingCost;
    }
    public double CalculateTotalCost()
    {
        foreach (Product product in _listOfProducts)
        {
            _totalCost += product.GetTotalPrice();
        }
        _totalCost += _shippingCost;
        return _totalCost;
    }
    public void GetPackingLabel(List<Product> listOfProducts)
    {
        // Return name and product id of each product in the order
        foreach (Product product in listOfProducts)
        {
            _packingLabel += $"{product.GetProductName()} {product.GetProductId()} (x{product.GetQuantity()})\n";
        }
    }
    public void GetShippingLabel(Customer customer)
    {
        // Return name and address of the customer
        string customerName = customer.GetCustomerName();
        Address customerAddress = customer.GetCustomerAddress();
        string customerAddressString = customerAddress.GetAddressString();
        _shippingLabel = $"{customerName}\n{customerAddressString}\n";
    }
    public void GetReceipt(List<Product> listOfProducts)
    {
        foreach (Product product in listOfProducts)
        {
            _receipt += $"{product.GetProductName()}(s) ${Math.Round(product.GetTotalPrice(),2)}\n";
        }
        _receipt += $"Shipping Cost: ${Math.Round(_shippingCost,2)}";
    }
}