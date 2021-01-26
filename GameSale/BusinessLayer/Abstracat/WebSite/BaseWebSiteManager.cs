using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.WebSite
{
    public abstract class BaseWebSiteManager : IWebSiteService
    {
        public virtual void AddGame(Game game)
        {
            Console.WriteLine("Add to DB :" + game.Id + game.Name + game.Price);
        }

        public virtual void BuyGame(User user, Game game)
        {

            Console.WriteLine("BuyDb to DB :" + game.Id + game.Name + game.Price + user.Id + user.Name + user.LastName + user.UserName + user.Status + user.Wallet);
        }

        public virtual void DeleteGaame(Game game)
        {
            Console.WriteLine("Delete to DB :" + game.Id + game.Name + game.Price);
        }

        public virtual void FreeGame(User user, Game game)
        {
            Console.WriteLine("FreeGame to DB :" + game.Id + game.Name + game.Price + user.Id + user.Name + user.LastName + user.UserName + user.Status + user.Wallet);
        }

        public virtual void UpdateGame(Game game)
        {
            Console.WriteLine("Delete to DB :" + game.Id + game.Name + game.Price);
        }
    }
}