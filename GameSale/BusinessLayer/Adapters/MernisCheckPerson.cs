using Odev6GameSale.BusinessLayer.Abstract.Users;
using Odev6GameSale.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.BusinessLayer.Adapters
{
    public class MernisCheckPerson : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {

            if (user.Status = true && user.Name.Length > 1 && user.LastName.Length > 1 && user.NationalityNo.Length == 11 && user.BrithDay > 1900)
            {
                Console.WriteLine(user.Name + " " + user.LastName + " kişi doğrulandı.");
                return true;
            }

            else
            {
                Console.WriteLine(user.Name + " " + user.LastName + " kişi doğrulanamadı.");
                return false;
            }

        }
    }
}