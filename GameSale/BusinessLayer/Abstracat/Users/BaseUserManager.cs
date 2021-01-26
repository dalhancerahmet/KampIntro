using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Abstract.Users
{
    public abstract class BaseUserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine("Add to DB :" + user.Id + user.Name + user.LastName + user.NationalityNo + user.BrithDay + user.NationalityNo + user.UserName + user.Password + user.Status);
        }

        public void Delete(User user)
        {
            Console.WriteLine("Delete to DB :" + user.Id + user.Name + user.LastName + user.NationalityNo + user.BrithDay + user.NationalityNo + user.UserName + user.Password + user.Status);
        }

        public void Update(User user)
        {
            Console.WriteLine("Update to DB :" + user.Id + user.Name + user.LastName + user.NationalityNo + user.BrithDay + user.NationalityNo + user.UserName + user.Password + user.Status);
        }
    }
}