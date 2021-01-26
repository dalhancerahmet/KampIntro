using Odev6GameSale.BusinessLayer.Abstract.Users;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}