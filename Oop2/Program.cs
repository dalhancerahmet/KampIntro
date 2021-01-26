using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bireysel müşteri
            IndividualCustomer customer = new IndividualCustomer();
            customer.Id = 1;
            customer.CustomerNo = "2331";
            customer.CustomerName = "Ahmet";
            customer.CustomerLastname = "Dalhançer";

            //Tüzel müşteri
            CorporateCustomer corporate = new CorporateCustomer();
            corporate.Id = 1;
            corporate.CustomerNo = "56";
            corporate.CompanyName = "Efinans";
            corporate.CompanyVkn = "1234567892";

            //customer evebeyn olduğu için her iki class'ın da referansını tutabilir
            Customer customer1 = new CorporateCustomer();
            Customer customer2 = new IndividualCustomer();

            //Manager sınıfı bizden müşteri istediği için biz hem gerçek hem de tüzel kişiyi gönderebiliyoruz.Çünkü Customer her ikisinin de evebeyni
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
