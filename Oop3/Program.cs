using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacCrediManager = new IhtiyacCrediManager();
            ICrediManager tasitCrediManager = new TasitCrediManager();
            ICrediManager konutCrediManager = new KonutCrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            //kredi tipini ve loglama tipini gönderdik
            basvuruManager.BasvuruYap(konutCrediManager, new List<ILoggerService>{ new DatabaseLoggerService(), new FileLoggerService() });

            //ICrediManager türünde bir liste oluşturduk ve içerisine seçtiğimiz kredi tiplerini attık.
            List<ICrediManager> crediManagers = new List<ICrediManager>() { ihtiyacCrediManager, tasitCrediManager };
            //oluşturduğumuz listeyi basvuruManager içerisindeki CrediOnBilgilendirmesiYap metoduna gönderdik.
            basvuruManager.CrediOnBilgilendirmesiYap(crediManagers);
            
            
        }
    }
}
