using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
     Address address = new Address("123 Main St", "Springfield", "IL", "USA");   
    Customer customer = new Customer("Sung",address);
    Order order = new Order(customer);

    Product product1 = new Product("Bananas", "45", 1.98f,2);
    Product product2 = new Product("Kiwi", "32", 2.99f,5);

    order.AddProduct(product1);
    order.AddProduct(product2);

    Address address2 = new Address("Manzana 135", "Lima", "Peru", "Peru");   
    Customer customer2 = new Customer("Peggy",address2);
    Order order2 = new Order(customer2);

    Product product3 = new Product("Maracuya", "77", 1.15f,6);
    Product product4 = new Product("Granadilla", "32", 3.99f,4);

    order2.AddProduct(product3);
    order2.AddProduct(product4);
    

    order.CreatePackingLabel();
    order.CreateShippingLabel();
Console.WriteLine($"Total Cost: {order.CalculateTotal()}");

 order2.CreatePackingLabel();
    order2.CreateShippingLabel();
Console.WriteLine($"Total Cost: {order2.CalculateTotal()}");
    }
}