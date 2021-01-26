using Odev6GameSale.Entities.Abstract;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Sale
{
    public interface ISaleService
    {
        void Sale(User user, Game game);
        void Add(User user1, IEntity fifa);
        void Sale(User user1, object game);
    }
}