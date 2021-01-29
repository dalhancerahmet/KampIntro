using GameProject.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(new Entities.Gamer { Id = 1, FirsName = "Ahmet", LastName = "Dalhançer", BirthYear = 1994, IdentityNumber = 55543264082 });

        }
    }
}
