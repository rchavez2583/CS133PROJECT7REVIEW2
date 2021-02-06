using System;
using System.Collections.Generic;
using System.Linq;

namespace CS133PROJECT7
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageInventory newInventory = new ManageInventory();

            Product myProduct = new Product();
            myProduct.ProductId = 1;
            myProduct.ProductName = "Action Fifure";

            newInventory.AddProducts("ABC123",);

            
            
            




        }
    }
}

public class ManageInventory
{

    private Dictionary<string, Product> products = new Dictionary<string, Product>();

    public void AddProducts(string Key, Product theProduct)
    {

        bool sectionInUse = products.ContainsKey(Key);

        if(sectionInUse)
        {
            Console.WriteLine("Section already in use");
        }
        else
        {
            products.Add(Key, theProduct);

            Console.WriteLine("Product has been");
        }

        
    }



}
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
}
    


