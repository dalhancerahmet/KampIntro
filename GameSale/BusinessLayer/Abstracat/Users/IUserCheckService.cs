using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Users
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}