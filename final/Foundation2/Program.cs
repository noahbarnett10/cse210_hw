using System;

class Program
{
    static void Main(string[] args)
    {
        Product P1 = new Product("Laptop", "ABC123", 600, 1);
        Product P2 = new Product("Calculator", "DEF456", 80, 1);
        Product P3 = new Product("Note Pad", "GHI789", 1, 10);
        Product P4 = new Product("Acrylic Paint", "JKL123", 4, 2);
        Product P5 = new Product("Frame", "MNO456", 10, 3);
        Product P6 = new Product("Headphones", "PQR789", 120, 1);

        Address A1 = new Address("1234 SW 2nd Street", "Rexburg", "ID", "USA");
        Address A2 = new Address("1234 Charleston Ave", "Edmonton", "Alberta", "Canada");

        Customer C1 = new Customer("John Smith", A1);
        Customer C2 = new Customer("John Doe", A2);
        
        Order O1 = new Order(C1);
        O1.AddProduct(P1);
        O1.AddProduct(P2);
        O1.AddProduct(P3);

        Order O2 = new Order(C2);
        O2.AddProduct(P4);
        O2.AddProduct(P5);
        O2.AddProduct(P6);

        Console.WriteLine("--- Order 1 Details --- ");
        Console.WriteLine(O1.GetShippingLabel());
        Console.WriteLine(O1.GetPackingLabel());
        Console.WriteLine("---------------");
        Console.WriteLine($"Total Price: ${O1.GetTotalPrice():0.00}\n");


        Console.WriteLine("--- Order 2 Details ---");
        Console.WriteLine(O2.GetShippingLabel());
        Console.WriteLine(O2.GetPackingLabel());
        Console.WriteLine("---------------");
        Console.WriteLine($"Total Price: ${O2.GetTotalPrice():0.00}\n");
    }
}