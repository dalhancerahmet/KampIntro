using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.Entities.Concrete
{
    //Her User,Persondan kalıtılmıştır
    public class User : Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Wallet { get; set; }
        public bool Status { get; set; }
    }
}