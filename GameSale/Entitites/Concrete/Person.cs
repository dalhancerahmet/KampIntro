using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.Entities.Concrete
{
    //Her Person IEntityden türemiştir
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string NationalityNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BrithDay { get; set; }
    }
}