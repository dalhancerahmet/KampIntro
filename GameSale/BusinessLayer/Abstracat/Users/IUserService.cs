using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Users
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);

    }
}