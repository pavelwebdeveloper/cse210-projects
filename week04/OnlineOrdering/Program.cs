using System;

// https://learn.microsoft.com/en-us/dotnet/api/system.environment.newline?view=net-9.0

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Order> _orders = new List<Order>();
        int numberOfOrder = 1;

        Product product1 = new Product("shirt", 10, 20, 4);
        Product product2 = new Product("pants", 11, 25, 3);
        Product product3 = new Product("t-shirt", 12, 10, 5);
        Product product4 = new Product("scarf", 13, 5, 1);
        Product product5 = new Product("coat", 14, 40, 1);



        Address address1 = new Address("23 Baker Str.", "Salt Lake City", "Utah", "USA");
        Customer customer1 = new Customer("Luke Skywalker", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);
        order1.AddProduct(product5);

        _orders.Add(order1);


        Address address2 = new Address("100 Palm Str.", "Tuxtla Gutiérrez", "Chiapas", "Mexico");
        Customer customer2 = new Customer("Pedro Lopez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        _orders.Add(order2);

        Console.WriteLine();
        Console.WriteLine("                 Online Ordering                     ");
        Console.WriteLine();

        foreach (Order order in _orders)
        {
            Console.WriteLine($"     Order #{numberOfOrder}     ");
            Console.WriteLine();
            Console.WriteLine($"Order {numberOfOrder} packing label:");
            Console.WriteLine();
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"Order {numberOfOrder} shipping label:");
            Console.WriteLine();
            Console.WriteLine(order.ShipingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total cost of the order {numberOfOrder} is {order.OrderTotalCost()} $");
            Console.WriteLine();
            Console.WriteLine();

            numberOfOrder++;
        }
    }
}