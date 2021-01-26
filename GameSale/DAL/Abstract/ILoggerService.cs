using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.DAL.Abstract
{
    //ILoggerService giriş,ekleme,güncelleme,delete işlemlerini simule etmek için oluşturuldu.
    public interface ILoggerService
    {
        void Log(IEntity entity);
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}