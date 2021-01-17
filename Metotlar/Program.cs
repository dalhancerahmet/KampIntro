using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager sepetManager = new SepetManager();
            bool gelendeger = sepetManager.SepetGosterilsinMi();
            Console.WriteLine(gelendeger);
            if (gelendeger == true)
            {
                Console.WriteLine("Ürünler gösterildi");
            }
            else
            {
                Console.WriteLine("Ürünü görmeye yetkiniz yoktur.");
            }
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Karpuz";
            urun1.UrunFiyati = 10;
            urun1.UrunAciklamasi = "Diyarbakır karpuzu";

            Console.WriteLine(urun1.UrunAdi);

            Urun[] urunler = new Urun[] {
            new Urun{ UrunAdi="Kayısı", UrunFiyati=25, UrunAciklamasi="Malatya Kayısısı", UrunId=1},
            new Urun{ UrunAdi="elma", UrunFiyati=6, UrunAciklamasi="amasya", UrunId=2}
            };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunId + " " + urun.UrunAdi);
            }
            Console.WriteLine("-------------------------");
            sepetManager.Ekle(new Urun { UrunAdi = "Elma" });
            sepetManager.Ekle(new Urun { UrunAdi = "Kayısı" });

            sepetManager.Ekle2("Vişne", 15);
        }
    }
}
