using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("Bartolome de las Casas", "Trujillo", "La Libertad", "Peru");
        Customer customer1 = new Customer("Jean", address1);
        Product product1 = new Product("Cepillo", 3342, 20.5, 2);
        Product product2 = new Product("Mayonesa", 5576, 18, 1);
        Product product3 = new Product("Mermelada", 9851, 12, 3);
        Order order1 = new Order(customer1);

        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"El costo Total de la orden es {order1.TotalCostOrder()} soles");



        Address address2 = new Address("77 Easton Street", "Nantucket", "Massachussets", "USA");
        Customer customer2 = new Customer("Ruth", address2);
        Product product4 = new Product("Bread", 5562, 2.5, 2);
        Product product5 = new Product("Apple Juice", 8856, 7.5, 2);
        Product product6 = new Product("Chicken Bread", 9685, 17, 3);
        Order order2 = new Order(customer2);

        order2.AddProducts(product4);
        order2.AddProducts(product5);
        order2.AddProducts(product6);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"El costo Total de la orden es {order2.TotalCostOrder()} soles");



    }
}