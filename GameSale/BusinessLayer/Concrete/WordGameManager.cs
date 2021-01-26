using Odev6GameSale.BusinessLayer.Abstract.Campaign;
using Odev6GameSale.BusinessLayer.Abstract.Sale;
using Odev6GameSale.BusinessLayer.Abstract.Users;
using Odev6GameSale.BusinessLayer.Abstract.WebSite;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Concrete
{
    //Ayrıca hepsi bir BaseWebSiteManager

    public class WordGameManager : BaseWebSiteManager
    {
        //Kullanıcı var mı böyle birisi?
        //Kampanya var mı?
        //Satış işlemi yapıldımı?
        private IUserCheckService _userCheckService;
        private ICampaignService _campaignService;
        private ISaleService _saleService;
        //dependancy enjection yönetemi kullanıldı

        public WordGameManager(IUserCheckService userCheckService, ICampaignService campaignService, ISaleService saleService)
        {
            _userCheckService = userCheckService;
            _campaignService = campaignService;
            _saleService = saleService;
        }

        public override void AddGame(Game game)
        {
            base.AddGame(game);
        }

        public override void BuyGame(User user, Game game)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.BuyGame(user, game);
                Console.WriteLine(_saleService + "Satış işlemi yapabilir.");
                Console.WriteLine(_campaignService + "Kampanyadan yararlanabilir.");
            }
            else
            {
                throw new Exception("Böyle bir kişi yok");

            }

        }
        public override void DeleteGaame(Game game)
        {
            base.DeleteGaame(game);
        }
        public override void FreeGame(User user, Game game)
        {
            base.FreeGame(user, game);
        }
        public override void UpdateGame(Game game)
        {
            base.UpdateGame(game);
        }
    }
}