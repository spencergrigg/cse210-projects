using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

public class Order{
    private Customer _customer = new Customer();
    private List<Product> _products = new List<Product>();
    private double _shippingCost;

    public Order(Address address, Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }

    private void CalculateShippingCost(){
        if (_customer.GetUSA())
        {
            _shippingCost = 5;
        }
        else
            _shippingCost = 35;
    }
    public void CalculateTotal(){
        double _sum = 0;
        CalculateShippingCost();
            foreach (Product item in _products){
                double _price = item.GetProductPrice();
                _sum += _price;
            }
        double _total = _sum + _shippingCost;
        Console.WriteLine($"Your total is: ${Math.Round(_total, 2)}"); 
    }

    public void GetShippingLabel(){
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetShippingAddress());
        Console.WriteLine("-----------------------------------------------------");

    }

    public void GetPackingLabel(){
        Console.WriteLine("Products:");
        foreach (Product item in _products)
        {
        Console.WriteLine($"{item.GetProductName()} - {item.GetId()}");
        }
        Console.WriteLine("-----------------------------------------------------");
        //display name and product id
}

    
}
