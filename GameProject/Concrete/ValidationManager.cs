using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class ValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.IdentityNumber==55543264082 && gamer.FirsName=="Ahmet" && gamer.LastName=="Dalhançer" && gamer.BirthYear == 1994)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
