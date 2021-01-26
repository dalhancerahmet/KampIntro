using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }//Ürün adı
        public double UnitPrice { get; set; } //Birim fiyat
        public int UnitInStock { get; set; } //Stok adedi
    }
}
