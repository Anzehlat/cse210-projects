using System;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //addresses
        Address usaAddress = new Address("100 Main St", "American Fork", "UT", "USA");
        Address internationalAddress = new Address("200 Maple Ln", "Alberta", "Calgary", "Canada");

        //customers
        Customer usaCustomer = new Customer("Zehla Wolfley", usaAddress);
        Customer internationalCustomer = new Customer("Bobby Wolfley", internationalAddress);

        //products
        Product product1 = new Product("Lotion", 1, 10.0, 2);
        Product product2 = new Product("Backpack", 2, 15.0, 1);

        //orders
        List<Product> orderProducts1 = new List<Product> { product1, product2 };
        Order order1 = new Order(usaCustomer, orderProducts1);

        List<Product> orderProducts2 = new List<Product> { product2 };
        Order order2 = new Order(internationalCustomer, orderProducts2);

        //show order results
        Console.WriteLine("Order 1:\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        Console.WriteLine("Order 2:\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}\n");
    }
}