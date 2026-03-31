using System.Security.Cryptography.X509Certificates;

class Product
{
private string name;
private string product_id;

private float pricePerUnit;

private int quantity;

public Product(string name,string product_id,float pricePerUnit, int quantity)
    {
     this.name = name;
     this.product_id = product_id;
     this.pricePerUnit = pricePerUnit;
     this.quantity = quantity;   
    }

    public float GetTotalCost()
    {
     return pricePerUnit * quantity;   
    }
public string GetProduct_id()
    {
      return product_id;  
    }

    public string GetName()
    {
     return name;   
    }
}