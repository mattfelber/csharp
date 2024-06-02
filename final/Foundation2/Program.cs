using System;

public class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Mouse", 101, 19.99, 2);
        Product product2 = new Product("Laptop", 202, 799.99, 1);
        Product product3 = new Product("Monitor", 303, 9.99, 1);

        // addresses
        Address address1 = new Address("1 Life Way", "Sherwood", "CA", "USA");
        Address address2 = new Address("456 Maple", "Louis Vuianna", "Onchario", "Panada");

        // customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        
        // orders
        List<Product> order1Products = new List<Product>() { product1, product2 };
        Order order1 = new Order(order1Products, customer1);

        List<Product> order2Products = new List<Product>() { product3, product1 };
        Order order2 = new Order(order2Products, customer2);

        //order details
        Console.WriteLine("Order 1 Details");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        Console.WriteLine("\nOrder 2 Details ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }



}