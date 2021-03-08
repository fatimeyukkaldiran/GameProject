using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("User is added");
            }
            else
            {
                Console.WriteLine("Validation is unsuccessful, register is failed");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated");
        }
    }
}
