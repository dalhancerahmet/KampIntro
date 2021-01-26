using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.WebSite
{
    public interface IWebSiteService
    {
        void BuyGame(User user, Game game);
        void FreeGame(User user, Game game);
        void AddGame(Game game);
        void DeleteGaame(Game game);

        void UpdateGame(Game game);
    }
}