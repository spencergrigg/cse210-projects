using System;

class Program
{
    static void Main(string[] args)
    {


//----------------------------------------------Order 1----------------------------------------------//
        //Creates Objects
        Address address1 = new Address("2004 E AutumnBreeze St", "Boise", "Idaho", "USA");
        Customer cust1 = new Customer("Spencer Grigg", address1);
        List<Product> products1 = new List<Product>();
        
        //Creates Products and adds them to the list
        Product product1 = new Product("Sweet Almond Oil", "9257323", 13.55, 3);
        products1.Add(product1);
        Product product2 = new Product("Jaw Exerciser", "2223456", 27.17, 2);
        products1.Add(product2);

        //Creates the Order and prints out the Shipping Label, Packing Label and the Order total
        Order order1 = new Order(address1, cust1, products1);
        Console.WriteLine("Order 1");
        order1.GetShippingLabel();
        order1.GetPackingLabel();
        order1.CalculateTotal();
        Console.WriteLine();

//------------------------------------------------Order 2---------------------------------------------------//
        //Creates Objects
        Address address2 = new Address("2023 W WinterFreeze Ave", "Cardston", "Alberta", "Canada");
        Customer cust2 = new Customer("Ariana Grigg", address2);
        List<Product> products2 = new List<Product>();
        
        //Creates Products and adds them to the list
        Product product3 = new Product("Organic Tallow", "9257323", 20, 1);
        products2.Add(product3);
        Product product4 = new Product("Toe Socks", "4685098", 20, 4);
        products2.Add(product4);

        //Creates the Order and prints out the Shipping Label, Packing Label and the Order total
        Order order2 = new Order(address2, cust2, products2);
        Console.WriteLine("Order 2");
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        order2.CalculateTotal();
    }
}