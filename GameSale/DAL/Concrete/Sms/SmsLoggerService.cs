using Odev6GameSale.DAL.Abstract;
using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.DAL.Concrete.Sms
{
    public class SmsLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Sms ekleme işlemi gerçekleştirildi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Sms silme işlemi gerçekleştirildi.");
        }

        public void Log(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Sms giriş işlemi gerçekleştirildi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("ID: " + entity.Id + " -Adı: " + entity.Name + "Sms güncelleme işlemi gerçekleştirildi.");
        }
    }
}