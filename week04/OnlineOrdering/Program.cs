using System;

class Program
{
    static void Main(string[] args)
    {
        //Author: Helaman Del Castillo - Online Ordering Project

        double shippingCost = 35.00;
        double price = 0;
        string option;
        Console.WriteLine("Welcome to HF Apparels! Here are your orders for today: \n");


        //Order 1
        Address address = new Address("Flinders St.", "Melbourne", "Victoria", "Australia");
        Customer cust = new Customer(address, "Helaman Del Castillo");
        Product product = new Product("Nike SB Dunks", "HF0001", 2.4, 12);

        //Order 2
        Address address2 = new Address("Collins St.", "Melbourne", "Victoria", "Australia");
        Customer cust2 = new Customer(address2, "James Bond");
        Product product2 = new Product("Labubu dolls", "HF0002", 1.13, 24);

        Order order1 = new Order(cust, product);
        Order order2 = new Order(cust2, product2);

        Console.WriteLine("Enter the order # to print the delivery details and total cost: ");
        option = Console.ReadLine();

        if (option == "1")
        {
            price = shippingCost + product.TotalCost();
            Console.WriteLine("\nShipping label: " + order1.ShippingLabel());

            Console.WriteLine("\nPacking label: " + order1.PackingLabel());
            Console.WriteLine($"\nTotal price: $ {price:F2}");
        }
        else if (option == "2")
        {
            price = shippingCost + product2.TotalCost();
            Console.WriteLine("\nShipping label: " + order2.ShippingLabel());

            Console.WriteLine("\nPacking label: " + order2.PackingLabel());
            Console.WriteLine($"\nTotal price: $ {price:F2}");
        }
        else
        {
            Console.WriteLine("Kindly enter a valid order #.\n");
        }
        Environment.Exit(0);

    }
}