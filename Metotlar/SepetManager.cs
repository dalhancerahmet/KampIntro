using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public bool SepetGosterilsinMi()
        {
            return true;
        }
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün eklendi.{0}", urun.UrunAdi);
        }
        public void Ekle2(string adi, double fiyat)
        {
            Console.WriteLine("Ürün eklendi.{0}", adi);
            Console.WriteLine("Ürün fiyatı:{0}", fiyat + "Tl");
        }
    }
}