using GameProject.Business.Abstract;
using GameProject.DataAccess.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        IGamerDal _gamerDal;
        public GamerManager(IUserValidationService userValidationService, IGamerDal gamerDal)
        {
            _userValidationService = userValidationService;
            _gamerDal = gamerDal;
        }

        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                _gamerDal.Add(gamer);
                Console.WriteLine("User is added");
            }
            else
            {
                Console.WriteLine("Validation is unsuccessful, register is failed");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            _gamerDal.Delete(gamer);
        }

        public List<Gamer> GetAll()
        {
            return _gamerDal.GetAll();
        }

        public List<Gamer> GetAllByCampaignId(int campaignId)
        {
            return _gamerDal.GetAllByCampaignId(campaignId);
        }

        public List<Gamer> GetAllByGameId(int gameId)
        {
            return _gamerDal.GetAllByGameId(gameId);
        }

        public void Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
            Console.WriteLine("Gamer is updated");
        }

    }
}
