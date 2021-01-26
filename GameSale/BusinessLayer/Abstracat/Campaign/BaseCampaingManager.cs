using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Campaign
{
    //Kampanya Manager,ekleme silme güncelleme implement edildi
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Add to DB :" + game.Id + game.Name + game.Price);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Delete to DB :" + game.Id + game.Name + game.Price);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Delete to DB :" + game.Id + game.Name + game.Price);
        }
    }
}