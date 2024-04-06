using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Products
        Product apple = new Product("Apple", 1, 0.75, 9);
        Product banana = new Product("Banana", 2, 0.50, 8);

        // address
        Address address = new Address("124 Seurat Lane", "Martinsburg", "West Virginia", "USA");

        //  customer
        Customer customer = new Customer("Nana Kwame Dickson", address);

        // An order to add products
        Order order = new Order(customer);
        order.AddProduct(apple);
        order.AddProduct(banana);

        // Display the packing label, shipping label, and total price
        Console.WriteLine("Packing Label:\n" + order.PackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order.ShippingLabel());
        Console.WriteLine("\nTotal Price: $ " + order.TotalPrice());
    }
}