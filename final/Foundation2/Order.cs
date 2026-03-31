class Order
{
    


private Customer customer;

private List<Product> products = new List<Product>();

public Order(Customer customer)
    {
        this.customer = customer;
    }

public void AddProduct(Product product)
    {
        products.Add(product);
    }
public void CreatePackingLabel()
    {
     foreach(var product in products)
    { 
        Console.WriteLine($"{product.GetName()} {product.GetProduct_id()}");
    }
    }
    public void CreateShippingLabel()
    {
      Console.WriteLine($"{customer.GetCustomerInfo()}");  
    }

    public int CalculateShippingCost()
    {
        if (customer.IsInUSA())
        {
         return 5;   
        }
        return 35;
    }

    public float CalculateTotal()
    {
        float total = 0;
        foreach(var product in products)
        {
         total += product.GetTotalCost();
        }
        total += CalculateShippingCost();

      return total;  
    }
    


}

