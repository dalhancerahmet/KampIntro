using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    public class CorporateCustomer:Customer
    {
        //Corparate = tüzel
        //inheritance -- miras alma
        
        public string CompanyName { get; set; }
        public string CompanyVkn { get; set; }
    }
}
