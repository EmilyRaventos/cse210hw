using System;

class Program
{
    static List<Product> _listOfProducts;
    static void Main(string[] args)
    {
        List<Product> listOfProducts = new List<Product>();
        _listOfProducts = listOfProducts;

        // Create first customer and address
        Address a1 = new Address("514 W Pumpkin dr.", "Rexburg", "Idaho", "USA");
        Customer c1 = new Customer("Alie Johnson", a1);

        // Create the corresponding list of products
        Product p1 = new Product("apple", 1, 0.25, 6);
        Product p2 = new Product("banana", 2, 0.5, 8);
        Product p3 = new Product("orange", 3, 0.75, 3);

        // Create the order
        Order o1 = new Order(c1);
        o1.CalculateShippingCost(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.CalculateTotalCost();
        _listOfProducts = o1.GetListOfProducts();

        // Create the labels
        o1.GetPackingLabel(_listOfProducts);
        o1.GetShippingLabel(c1);

        o1.DisplayOrder();

        // Create second customer and address
        Address a2 = new Address("729 S Lily st.", "New Westminster", "British Columbia", "Canada");
        Customer c2 = new Customer("Oliver Hatch", a2);

        // Create the corresponding list of products
        Product p4 = new Product("book", 1, 5.25, 5);
        Product p5 = new Product("chair", 2, 25, 2);
        Product p6 = new Product("desk", 3, 175, 1);

        // Create the order
        Order o2 = new Order(c2);
        o2.CalculateShippingCost(c2);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.CalculateTotalCost();
        _listOfProducts = o2.GetListOfProducts();

        // Create the labels
        o2.GetPackingLabel(_listOfProducts);
        o2.GetShippingLabel(c2);

        o2.DisplayOrder();
    }
}