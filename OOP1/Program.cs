using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Masa";
            product.CategoryId = 2;//mobilya
            product.UnitPrice = 500;
            product.UnitInStock = 3;

            Product product1 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 10 };
            ProductManager productManager = new ProductManager();
            productManager.Add(new Product { ProductName = "Mouse" });

            List<string> isimler = new List<string> { "Ahmet", "Enes", "Sadık" };
            isimler.Add("Mehmet");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }

            int KacIsimVar = isimler.Count;
            Console.WriteLine("Listedeki toplam kişi sayısı:"+KacIsimVar);
        }
    }
}
