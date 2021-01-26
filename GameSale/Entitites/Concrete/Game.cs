using Odev6GameSale.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev6GameSale.Entities.Concrete
{
    //Her Game,IEntity den türemiştir.
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}