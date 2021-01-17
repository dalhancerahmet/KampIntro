using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikarim = sayi1 - sayi2;
            Console.WriteLine(cikarim);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bolum = sayi1 / sayi2;
            Console.WriteLine(bolum);
        }
    }
}
