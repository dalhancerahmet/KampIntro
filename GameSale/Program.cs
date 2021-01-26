using Odev6GameSale.BusinessLayer.Abstract;
using Odev6GameSale.BusinessLayer.Abstract.Campaign;
using Odev6GameSale.BusinessLayer.Abstract.Sale;
using Odev6GameSale.BusinessLayer.Abstract.Users;
using Odev6GameSale.BusinessLayer.Abstract.WebSite;
using Odev6GameSale.BusinessLayer.Adapters;
using Odev6GameSale.BusinessLayer.Concrete;
using Odev6GameSale.DAL.Abstract;
using Odev6GameSale.DAL.Concrete.Database;
using Odev6GameSale.DAL.Concrete.File;
using Odev6GameSale.DAL.Concrete.Sms;
using Odev6GameSale.Entities.Abstract;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Odev6GameSale
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerde,implement ettiği class'ın referansını tutabilir
            ILoggerService dbLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService smsLogger = new SmsLoggerService();
            ISaleService saleService = new BaseSaleManager();
            //IUserCheckService userCheckService = UserCheckManager();
            //IWebSiteService webSiteService = new WordGameManager(new MernisCheckPerson, new BaseCampaignManager,new BaseSaleManager);
            //Çoklu loglama,ILoggerService ten loglama işlemleri 
            //IEntityService manager = new WordGameManager(new List<ISaleService> { saleService });

            List<ILoggerService> loggers = new List<ILoggerService> { dbLogger, fileLogger, smsLogger };

            User user1 = new User() { NationalityNo = "11111111111", Name = "Ahmet", LastName = "Dalhançer", Status = true, BrithDay = 1994, Wallet = "5500", UserName = "ahmt123" };
            IEntity fifa = new Game() { Id = 1, Name = "fifa2001", Price = 100 };

            saleService.Sale(user1, fifa);

        }
    }
}