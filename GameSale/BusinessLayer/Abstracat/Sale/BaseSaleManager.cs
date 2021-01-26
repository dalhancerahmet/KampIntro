using Odev6GameSale.Entities.Abstract;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Sale
{
    public class BaseSaleManager : ISaleService
    {
        public void Add(User user1, IEntity fifa)
        {
            throw new NotImplementedException();
        }

        public void Sale(User user, Game game)
        {
            Console.WriteLine(user.Id + user.UserName + user.Name + user.LastName + user.Wallet + "Satış işlemi yapaldı." + game.Name + "isimli oyunu aldınız alışverişiniz için teşekkürler");
        }

        public void Sale(User user1, object game)
        {
            Console.WriteLine("Seled!");
        }
    }
}