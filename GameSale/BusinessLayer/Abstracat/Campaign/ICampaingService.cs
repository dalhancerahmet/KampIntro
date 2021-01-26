using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Campaign
{
    //Oyun Kampnaylarını ekleme silme güncelleme Servisi
    public interface ICampaignService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}