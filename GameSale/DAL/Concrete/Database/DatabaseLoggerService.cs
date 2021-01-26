using Odev6GameSale.DAL.Abstract;
using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.DAL.Concrete.Database
{
    //Veritabanına Ekleme,Silme,Giriş,Güncelleme işlemi gerçekleştirlmesi simule edildi.
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Veritabanına ekleme işlemi gerçekleştirildi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Veritabanına silme işlemi gerçekleştirildi.");
        }

        public void Log(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Veritabanına giriş işlemi gerçekleştirildi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Veritabanına güncelleme işlemi gerçekleştirildi.");
        }
    }
}