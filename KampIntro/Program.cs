using System;

namespace KampIntro
{
    class Program
    { //test
        static void Main(string[] args)
        {
            Urunler[] urunlers = new Urunler[] {

            new Urunler
            {
                UrunId=1,
                UrunName="Kayısı",
                UrunStok=100,
                UrunBirimKodu="Kg"
            },

            new Urunler {
                UrunId=2,
                UrunName="Hediyelik Kayısı",
                UrunStok=50,
                UrunBirimKodu="Adet"
            }

            };

            Kullanicilar[] kullanicilars = new Kullanicilar[]
            {
                new Kullanicilar
                {
                    KullaniciId=1,
                    KullaniciAdi="Ahmet",
                    KullaniciMail="Ahmetdalhancer@gmail.com",
                    KullaniciRol="Admin",
                    KullaniciSoyadi="Dalhançer"
                },
                new Kullanicilar
                {
                    KullaniciId=2,
                    KullaniciAdi="Samet",
                    KullaniciMail="samet@gmail.com",
                    KullaniciRol="Yönetici",
                    KullaniciSoyadi="Dalhançer"
                },
                new Kullanicilar
                {
                    KullaniciId=3,
                    KullaniciAdi="Ramazan",
                    KullaniciMail="ramazan@gmail.com",
                    KullaniciRol="Maraba",
                    KullaniciSoyadi="Baturay"
                }
            };

            foreach (var urun in urunlers)
            {
                if (urun.UrunId == 2 || urun.UrunId == 1)
                {
                    Console.WriteLine("Ürün id:" + urun.UrunId + " " + urun.UrunName + " " + urun.UrunStok + urun.UrunBirimKodu);
                }
            }
            foreach (var kullanici in kullanicilars)
            {
                if (kullanici.KullaniciRol == "Admin")
                {
                    Console.WriteLine("Admin girişi sağlandı.");
                }
            }


        }
    }

    class Urunler
    {
        public int UrunId { get; set; }
        public string UrunName { get; set; }
        public int UrunStok { get; set; }
        public string UrunBirimKodu { get; set; }
    }
    class Kullanicilar
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciRol { get; set; }

    }
}
