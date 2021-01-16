using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " sepete eklendi!");
        }

        public void Add(string productName)
        {

        }
    }
}
