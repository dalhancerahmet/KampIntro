using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    public class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            crediManager.Calculate();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
        }
        //Liste türünde gelen kredileri crediManagers takma adıyla aldık
        public void CrediOnBilgilendirmesiYap(List<ICrediManager> crediManagers)
        {
            //crediManagers takma adıyla alınan liste foreach ile dolanıp herbir kredi türünün Calculate metodu çalıştırıldı.
            foreach (var credi in crediManagers)
            {
                credi.Calculate();
            }
        }
    }
}
