using System;
using System.Collections.Generic;

namespace DayTwoHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product
            {
                Name = "Bal",
                Category = "Arı Ürünleri",
                UnitInStock = 1000,
                Price = 120
            };

            var product2 = new Product
            {
                Name = "Polen",
                Category = "Arı Ürünleri",
                UnitInStock = 100,
                Price = 120
            };

            var product3 = new Product
            {
                Name = "Çekirdek Koloni",
                Category = "Arı",
                UnitInStock = 41,
                Price = 500
            };


            var product4 = new Product
            {
                Name = "Kraliçe Arı",
                Category = "Arı",
                UnitInStock = 50,
                Price = 80
            };

            var products = new List<Product> { product1, product2, product3, product4 };

            Console.WriteLine("For ile");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Ürün Adı: " + products[i].Name + "\n" + "Ürün Kategorisi: " + products[i].Category + "\n" + "Ürün Fiyatı: " + products[i].Price + "\n" + "Stok Adeti: " + products[i].UnitInStock + "\n");
            }


            Console.WriteLine("Foreach ile");

            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı: " + product.Name + "\n" + "Ürün Kategorisi: " + product.Category + "\n" + "Ürün Fiyatı: " + product.Price + "\n" + "Stok Adeti: " + product.UnitInStock + "\n");
            }

            Console.WriteLine("While ile");

            var j = 0;
            while (j < products.Count)
            {
                Console.WriteLine("Ürün Adı: " + products[j].Name + "\n" + "Ürün Kategorisi: " + products[j].Category + "\n" + "Ürün Fiyatı: " + products[j].Price + "\n" + "Stok Adeti: " + products[j].UnitInStock + "\n");
                j++;
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int UnitInStock { get; set; }
    }
}
