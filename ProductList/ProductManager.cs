using System;
using System.Collections.Generic;
using System.Text;

namespace ProductList
{
    public class ProductManager
    {
       private  List<Product> products  = new List<Product>();
       
       // Add Products
       public void AddProduct( Product product)
        {
            products.Add(product); 
        }
        // Get all products sorted by price
        public List<Product> GetallProducts() 
        { 
            return products.OrderBy (p => p.Price).ToList(); 
        }
        // Search products
        public List<Product> SearchProduct(String term)
        {
            return products.Where(p => p.Name.ToLower()
            .Contains(term.ToLower())).OrderBy(p => p.Price).ToList();
        }
        // Get total price
        public double GetTotalPrice(List<Product> list = null)
        {
            return (list ?? products).Sum(p => p.Price);
        }
        // Remove Products
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }



    }
}
