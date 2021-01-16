using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product
            {
                Name = "Elma",
                Price = 15,
                Info = "Amasya Elması",
                Id = 1
            };

            var product2 = new Product
            {
                Name = "Karpuz",
                Price = 80,
                Info = "Diyarbakır Karpuzu",
                Id = 2
            };

            var products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Info);
                Console.WriteLine(product.Id);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------Metotlar-----------");

            Console.WriteLine("Sepete eklemek istediğiniz ürünün id'sini giriniz: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var cartManager = new CartManager();
            var selectedProduct = products.FirstOrDefault(x => x.Id == id);
            cartManager.Add(selectedProduct);
        }
    }
}
