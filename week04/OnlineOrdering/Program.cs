using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 20, 2));

        Address addr2 = new Address("45 King Road", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Smith", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "P200", 600, 1));
        order2.AddProduct(new Product("Charger", "P201", 25, 2));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
        Console.WriteLine("-----------------------------------\n");
    }
}
